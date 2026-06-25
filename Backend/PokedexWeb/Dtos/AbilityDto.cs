using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexWeb.Dtos
{
    public class AbilityBasicDto : PokemonBasicDto
    {
    }

    public class AbilityBasicInfo : AbilityBasicDto
    {
        public string Effect { get; set; } = "";
        public string FlavorText { get; set; } = "";
    }
}
