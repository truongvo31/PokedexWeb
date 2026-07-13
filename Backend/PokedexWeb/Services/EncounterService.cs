using Microsoft.EntityFrameworkCore;
using PokedexWeb.Data;
using PokedexWeb.Dtos;
using PokedexWeb.Helpers;

namespace PokedexWeb.Services
{
    public class EncounterService
    {
        private readonly AppDbContext _context;

        public EncounterService(AppDbContext context)
        {
            _context = context;
        }

        //Design SQL: 
        //select
        //    v.name as game,
        //    la.name as location,
        //    em.name as method,
        //    emn.name as method_desc,
        //    ecvn.name as condition,
        //    SUM(es.rarity) as rarity
        //from encounter e
        //inner
        //join version v on v.id = e.version_id
        //inner
        //join locationarea la on la.id = e.location_area_id
        //inner
        //join encounterslot es on es.id = e.encounter_slot_id
        //inner
        //join encountermethod em on em.id = es.encounter_method_id
        //left
        //join encountermethodname emn
        //    on emn.encounter_method_id = em.id
        //    and emn.language_id = 9
        //left join encounterconditionvaluemap ecvm
        //    on ecvm.encounter_id = e.id
        //left join encounterconditionvalue ecv
        //    on ecv.id = ecvm.encounter_condition_value_id
        //left join encounterconditionvaluename ecvn
        //    on ecvn.encounter_condition_value_id = ecv.id
        //    and ecvn.language_id = 9
        //where e.pokemon_id = 25
        //group by
        //    v.name,
        //    la.name,
        //    em.name,
        //    emn.name,
        //    ecvn.name
        //order by v.version_group_id,v.id,la.name
        public async Task<EncounterDto> GetEncountersByPokemonIdAsync(int pokemonId)
        {
            var specialMethods = new[]
            {
                "npc-trade",
                "colosseum-bonus-disc-us",
                "colosseum-bonus-disc-jpn",
                "pokemon-channel-pal",
                "pokemon-ranger",
                "pokemon-battle-revolution",
                "new-york-pokecenter-wish-eggs"
            };

            var ingameRaw = await _context.Encounters.AsNoTracking()
               .Where(e => e.PokemonId == pokemonId && !specialMethods.Contains(e.EncounterSlot!.EncounterMethod!.Name))
               .Select(e => new EncounterRawDto
               {
                   Game = new EncounterVersionDto
                   {
                       Id = e.VersionId!.Value,
                       VersionGroupId = e.Version!.VersionGroupId!.Value,
                       Name = PokemonHelper.ToDisplayName(e.Version.Name),
                   },
                   Location = new EncounterBasicDto
                   {
                       Id = e.LocationAreaId!.Value,
                       Name = PokemonHelper.ToDisplayName(e.LocationArea!.Name)
                   },
                   Method = new EncounterBasicDto
                   {
                       Id = e.EncounterSlot!.EncounterMethodId!.Value,
                       Name = PokemonHelper.ToDisplayName(e.EncounterSlot!.EncounterMethod!.Name),
                   },
                   MethodDesc =
                       e.EncounterSlot.EncounterMethod.Encountermethodnames.Where(emn => emn.LanguageId == 9).First().Name,
                   Condition =
                       e.Encounterconditionvaluemaps
                       .Select(ecvm => ecvm.EncounterConditionValue!.Encounterconditionvaluenames
                           .Where(ecvn => ecvn.LanguageId == 9).First().Name)
                       .FirstOrDefault(),
                   Rarity = e.EncounterSlot.Rarity
               })
               .ToListAsync();

            var specialRaw = await _context.Encounters.AsNoTracking()
                .Where(e => e.PokemonId == pokemonId && specialMethods.Contains(e.EncounterSlot!.EncounterMethod!.Name))
                .Select(e => new EncounterRawDto
                {
                    Game = new EncounterVersionDto
                    {
                        Id = e.VersionId!.Value,
                        VersionGroupId = e.Version!.VersionGroupId!.Value,
                        Name = PokemonHelper.ToDisplayName(e.Version.Name),
                    },
                    Location = new EncounterBasicDto
                    {
                        Id = e.LocationAreaId!.Value,
                        Name = PokemonHelper.ToDisplayName(e.LocationArea!.Name)
                    },
                    Method = new EncounterBasicDto
                    {
                        Id = e.EncounterSlot!.EncounterMethodId!.Value,
                        Name = PokemonHelper.ToDisplayName(e.EncounterSlot!.EncounterMethod!.Name),
                    },
                    MethodDesc =
                        e.EncounterSlot.EncounterMethod.Encountermethodnames.Where(emn => emn.LanguageId == 9).First().Name,
                    Condition =
                        e.Encounterconditionvaluemaps
                        .Select(ecvm => ecvm.EncounterConditionValue!.Encounterconditionvaluenames
                            .Where(ecvn => ecvn.LanguageId == 9).First().Name)
                        .FirstOrDefault(),
                    Rarity = e.EncounterSlot.Rarity
                })
                .ToListAsync();

            return new EncounterDto
            {
                InGameEncounters = ProcessRawDto(ingameRaw),
                SpecialEncounters = ProcessRawDto(specialRaw),
            };
        }

        private List<EncounterGameNode> ProcessRawDto(List<EncounterRawDto> raw)
        {
            var grouped = raw.GroupBy(x => new
            {
                GameId = x.Game.Id,
                LocationId = x.Location.Id,
                MethodId = x.Method.Id,
                x.MethodDesc,
                x.Condition,
            }).Select(g => new EncounterRawDto
            {
                Game = g.First().Game,
                Location = g.First().Location,
                Method = g.First().Method,
                MethodDesc = g.First().MethodDesc,
                Condition = g.First().Condition,
                Rarity = g.Sum(x => x.Rarity),
            }).OrderBy(x => x.Game.VersionGroupId)
                .ThenBy(x => x.Game.Id)
                .ThenBy(x => x.Location.Name ?? "")
            .ToList();

            var result = grouped.GroupBy(x => x.Game.Id)
                .Select(gameGroup =>
                {
                    var firstGame = gameGroup.First();
                    return new EncounterGameNode
                    {
                        Game = firstGame.Game,
                        Locations = gameGroup.GroupBy(x => x.Location.Id)
                            .Select(locationGroup =>
                            {
                                var firstLocation = locationGroup.First();
                                return new EncounterLocationNode
                                {
                                    Location = firstLocation.Location,
                                    Methods = locationGroup.GroupBy(x => new
                                    {
                                        x.Method.Id,
                                        x.MethodDesc,
                                    }).Select(methodGroup =>
                                    {
                                        var firstMethod = methodGroup.First();
                                        return new EncounterMethodNode
                                        {
                                            Method = firstMethod.Method,
                                            MethodDesc = firstMethod.MethodDesc,
                                            Conditions = methodGroup.GroupBy(x => x.Condition)
                                                .Select(g =>
                                                {
                                                    var baseValue = methodGroup.Where(x => string.IsNullOrWhiteSpace(x.Condition))
                                                        .Sum(x => x.Rarity);
                                                    var condition = g.Key;
                                                    var value = g.Sum(x => x.Rarity);
                                                    return new EncounterConditionNode
                                                    {
                                                        Condition = condition ?? "Default",
                                                        Rarity = string.IsNullOrWhiteSpace(condition)
                                                            ? baseValue
                                                            : baseValue + value,
                                                    };
                                                }).ToList()
                                        };
                                    }).ToList()
                                };
                            }).ToList()
                    };
                }).ToList();
            return result;
        }
    }
}
