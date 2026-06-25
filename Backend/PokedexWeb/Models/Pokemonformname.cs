using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokemonformname
{
    public int Id { get; set; }

    public string PokemonName { get; set; } = null!;

    public int? LanguageId { get; set; }

    public int? PokemonFormId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Language? Language { get; set; }

    public virtual Pokemonform? PokemonForm { get; set; }
}
