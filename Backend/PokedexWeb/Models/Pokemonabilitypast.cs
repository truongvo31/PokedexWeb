using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokemonabilitypast
{
    public int Id { get; set; }

    public bool IsHidden { get; set; }

    public int Slot { get; set; }

    public int? AbilityId { get; set; }

    public int? GenerationId { get; set; }

    public int? PokemonId { get; set; }

    public virtual Ability? Ability { get; set; }

    public virtual Generation? Generation { get; set; }

    public virtual Pokemon? Pokemon { get; set; }
}
