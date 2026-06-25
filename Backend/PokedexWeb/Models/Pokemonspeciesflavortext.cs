using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokemonspeciesflavortext
{
    public int Id { get; set; }

    public string FlavorText { get; set; } = null!;

    public int? LanguageId { get; set; }

    public int? PokemonSpeciesId { get; set; }

    public int? VersionId { get; set; }

    public virtual Language? Language { get; set; }

    public virtual Pokemonspecy? PokemonSpecies { get; set; }

    public virtual Version? Version { get; set; }
}
