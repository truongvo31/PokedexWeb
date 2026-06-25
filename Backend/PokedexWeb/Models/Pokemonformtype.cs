using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokemonformtype
{
    public int Id { get; set; }

    public int Slot { get; set; }

    public int? PokemonFormId { get; set; }

    public int? TypeId { get; set; }

    public virtual Pokemonform? PokemonForm { get; set; }

    public virtual Type? Type { get; set; }
}
