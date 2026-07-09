using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using PokedexWeb.Data;
using PokedexWeb.Dtos;
using PokedexWeb.Helpers;

namespace PokedexWeb.Services
{
    public class PokemonService
    {
        private readonly AppDbContext _dbContext;
        public PokemonService(AppDbContext dbContext, IMemoryCache cache)
        {
            _dbContext = dbContext;
        }

        public async Task<List<PokemonDtoMin>> GetAllAsync()
        {
            return await _dbContext.Pokemons.AsNoTracking()
                    .Select(x => new PokemonDtoMin
                    {
                        Id = x.Id,
                        Name = PokemonHelper.ToDisplayName(x.Name),
                        Types = x.Pokemontypes.Select(pt => pt.Type)
                            .Select(t => PokemonHelper.ToDisplayName(t!.Name)).ToArray(),
                    })
                    .OrderBy(x => x.Id)
                    .ToListAsync();
        }

        public async Task<PokemonDto> GetPokemonInfoAsync(int id)
        {
            var allStatsForStat = await _dbContext.Pokemonstats
                .AsNoTracking()
                .GroupBy(s => s.StatId)
                .Select(g => new {
                    StatId = g.Key,
                    Values = g.Select(x => x.BaseStat).OrderBy(x => x).ToList()
                })
                .ToDictionaryAsync(x => x.StatId!.Value, x => x.Values);

            var allPokemonsCount = await _dbContext.Pokemons.AsNoTracking().CountAsync();

            var item = await _dbContext.Pokemons.AsNoTracking()
                .Select(x => new PokemonDto
                {
                    Id = x.Id,
                    Name = PokemonHelper.ToDisplayName(x.Name),
                    Height = x.Height ?? 0,
                    Weight = x.Weight ?? 0,
                    Title = x.PokemonSpecies!.Pokemonspeciesnames!.First(spn => spn.LanguageId == 9).Genus,
                    IsLegendary = x.PokemonSpecies.IsLegendary,
                    IsMythical = x.PokemonSpecies.IsMythical,
                    CaptureRate = x.PokemonSpecies.CaptureRate!.Value,
                    GenderRate = x.PokemonSpecies.GenderRate!.Value,
                    Stats = x.Pokemonstats.Select(s => new PokemonDtoStat
                    {
                        Id = s.StatId!.Value,
                        Name = PokemonHelper.ToDisplayName(s.Stat!.Name),
                        Value = s.BaseStat,
                        AllPokemonsCount = allPokemonsCount,
                    }).ToList(),
                    Types = x.Pokemontypes.Select(pt => pt.Type).Select(t => new PokemonBasicDto
                    {
                        Id = t!.Id,
                        Name = PokemonHelper.ToDisplayName(t!.Name),
                    }).ToList(),
                    Abilities = x.Pokemonabilities.Select(pa => pa.Ability).Select(a => new PokemonBasicDto
                    {
                        Id = a!.Id,
                        Name = PokemonHelper.ToDisplayName(a!.Name),
                    }).ToList()
                }).SingleOrDefaultAsync(x => x.Id == id) ?? throw new Exception("Not a single pokemon found");

            foreach (var stat in item.Stats)
            {
                var statList = allStatsForStat[stat.Id];
                stat.BetterThan = statList?.Count(x => x < stat.Value) ?? 0;
            }

            item.Generations = await GetAvailableGenerationsAsync(id);
            return item;
        }

        public async Task<PokemonNextPrev> GetNextPrevPokemonsAsync(int id)
        {
            var prevTask = _dbContext.Pokemons.AsNoTracking()
                .Where(p => p.Id < id).OrderByDescending(p => p.Id).Select(x => new PokemonDtoMin
                {
                    Id = x.Id,
                    Name = PokemonHelper.ToDisplayName(x.Name),
                }).FirstOrDefaultAsync();

            var nextTask = _dbContext.Pokemons.AsNoTracking()
                .Where(p => p.Id > id).OrderBy(p => p.Id).Select(x => new PokemonDtoMin
                {
                    Id = x.Id,
                    Name = PokemonHelper.ToDisplayName(x.Name),
                }).FirstOrDefaultAsync();

            await Task.WhenAll(prevTask, nextTask);

            return new PokemonNextPrev
            {
                Prev = await prevTask,
                Next = await nextTask
            };
        }

        public async Task<List<PokemonDtoMin>> GetEvolutionChainAsync(int pokemonId)
        {
            var species = await _dbContext.Pokemonspecies.AsNoTracking()
                .Where(ps =>
                    ps.EvolutionChainId == _dbContext.Pokemonspecies.Where(ps2 =>
                        ps2.Id == _dbContext.Pokemons.First(p => p.Id == pokemonId).PokemonSpeciesId)
                    .First().EvolutionChainId)
                .OrderBy(sp => sp.Order)
                .SelectMany(sp => sp.Pokemons.Select(p => new PokemonDtoMin
                {
                    Id = p.Id,
                    Name = PokemonHelper.ToDisplayName(p.Name),
                    Types = p.Pokemontypes.Select(t => t.Type)
                        .Select(t => PokemonHelper.ToDisplayName(t!.Name)).ToArray(),
                }).OrderBy(p => p.Id))
                .ToListAsync();
            return species;
        }

        public async Task<List<PokemonTypeEfficacyDto>> GetTypeEfficaciesAsync(int id)
        {
            var pokemonTypeIds = await _dbContext.Pokemons.AsNoTracking()
                .Where(x => x.Id == id).SelectMany(x => x.Pokemontypes.Select(t => t.TypeId!.Value)).ToArrayAsync();
            // Load all type efficacy rows that target any of the defender's types
            var rows = await _dbContext.Typeefficacies.AsNoTracking()
                .Include(x => x.DamageType)
                .Where(e => e.TargetTypeId.HasValue && pokemonTypeIds.Contains(e.TargetTypeId.Value))
                .ToListAsync();
            var result = rows
                .GroupBy(e => e.DamageTypeId!.Value)
                .Select(g => new
                {
                    Type = new PokemonBasicDto
                    {
                        Id = g.Key,
                        Name = PokemonHelper.ToDisplayName(g.First().DamageType!.Name),
                    },
                    Multiplier = g.Aggregate(1.0, (mult, row) => mult * (row.DamageFactor / 100.0)),
                })
                .GroupBy(x => Math.Round(x.Multiplier, 2))
                .OrderBy(g => g.Key)
                .Select(g => new PokemonTypeEfficacyDto
                {
                    Multiplier = $"{g.Key}x",
                    Types = g.Select(x => x.Type).ToArray()
                })
                .ToList();
            return result;
        }

        public async Task<List<PokemonBasicDto>> GetAvailableGenerationsAsync(int id)
        {
            var res = await _dbContext.Generations.AsNoTracking()
                .Where(g => g.Id >=
                    _dbContext.Pokemonforms.Where(pf => pf.PokemonId == id)
                        .Select(pf => pf.VersionGroup!.GenerationId)
                        .Min())
                .Select(g => new PokemonBasicDto
                {
                    Id = g.Id,
                    Name = PokemonHelper.GetGenerationName(g.Name),
                })
                .ToListAsync();
            return res;
        }
    }
}
