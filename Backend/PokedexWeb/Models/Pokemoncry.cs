using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokemoncry
{
    public int Id { get; set; }

    public string Cries { get; set; } = null!;

    public int? PokemonId { get; set; }

    public virtual Pokemon? Pokemon { get; set; }
}
