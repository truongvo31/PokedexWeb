using System.Collections.Generic;

namespace PokedexWeb.Dtos
{
    public class PokemonBasicDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
    }

    public class PokemonDto : PokemonBasicDto
    {
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Title { get; set; } = "";
        public bool IsLegendary { get; set; }
        public bool IsMythical { get; set; }
        public int CaptureRate { get; set; }
        public int GenderRate { get; set; }
        public List<PokemonDtoStat> Stats { get; set; } = [];
        public List<PokemonBasicDto> Types { get; set; } = [];
        public List<PokemonBasicDto> Abilities { get; set; } = [];
        public List<PokemonBasicDto> Generations { get; set; } = [];
    }

    public class PokemonDtoMin : PokemonBasicDto
    {
        public string[] ElementTypes { get; set; } = [];
    }

    public class PokemonNextPrev
    {
        public PokemonBasicDto? Prev { get; set; }
        public PokemonBasicDto? Next { get; set; }
    }

    public class PokemonDtoStat : PokemonBasicDto
    {
        public int Value { get; set; }
        public int BetterThan { get; set; }
        public int AllPokemonsCount { get; set; }
    }

    public class PokemonTypeEfficacyDto
    {
        public string Multiplier { get; set; } = "";
        public PokemonBasicDto[] Types { get; set; } = [];
    }
}
