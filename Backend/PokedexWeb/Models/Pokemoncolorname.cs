using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokemoncolorname
{
    public int Id { get; set; }

    public int? LanguageId { get; set; }

    public int? PokemonColorId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Language? Language { get; set; }

    public virtual Pokemoncolor? PokemonColor { get; set; }
}
