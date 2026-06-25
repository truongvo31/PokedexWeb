using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokemonhabitatname
{
    public int Id { get; set; }

    public int? LanguageId { get; set; }

    public int? PokemonHabitatId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Language? Language { get; set; }

    public virtual Pokemonhabitat? PokemonHabitat { get; set; }
}
