using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexWeb.Dtos
{
    public class EncounterBasicDto : PokemonBasicDto
    {
    }

    public class EncounterVersionDto : EncounterBasicDto
    {
        public int VersionGroupId { get; set; }
    }

    public class EncounterRawDto
    {
        public EncounterVersionDto Game { get; set; } = new();
        public EncounterBasicDto Location { get; set; } = new();
        public EncounterBasicDto Method { get; set; } = new();
        public string? MethodDesc { get; set; } = "";
        public string? Condition { get; set; }
        public int Rarity { get; set; }
    }

    public class EncounterDto
    {
        public List<EncounterGameNode> InGameEncounters { get; set; } = [];
        public List<EncounterGameNode> SpecialEncounters { get; set; } = [];
    }

    public class EncounterGameNode
    {
        public EncounterVersionDto Game { get; set; } = new();
        public List<EncounterLocationNode> Locations { get; set; } = [];

    }

    public class EncounterLocationNode
    {
        public EncounterBasicDto Location { get; set; } = new();
        public List<EncounterMethodNode> Methods { get; set; } = [];
    }

    public class EncounterMethodNode
    {
        public EncounterBasicDto Method { get; set; } = new();
        public string? MethodDesc { get; set; }
        public List<EncounterConditionNode> Conditions { get; set; } = [];
    }

    public class EncounterConditionNode
    {
        public string? Condition { get; set; }
        public int Rarity { get; set; }
    }
}
