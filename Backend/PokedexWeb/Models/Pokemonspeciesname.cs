using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokemonspeciesname
{
    public int Id { get; set; }

    public string Genus { get; set; } = null!;

    public int? LanguageId { get; set; }

    public int? PokemonSpeciesId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Language? Language { get; set; }

    public virtual Pokemonspecy? PokemonSpecies { get; set; }
}
