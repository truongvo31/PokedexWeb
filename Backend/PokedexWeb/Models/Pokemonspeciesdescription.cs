using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokemonspeciesdescription
{
    public int Id { get; set; }

    public int? LanguageId { get; set; }

    public int? PokemonSpeciesId { get; set; }

    public string Description { get; set; } = null!;

    public virtual Language? Language { get; set; }

    public virtual Pokemonspecy? PokemonSpecies { get; set; }
}
