using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokemondexnumber
{
    public int Id { get; set; }

    public int PokedexNumber { get; set; }

    public int? PokedexId { get; set; }

    public int? PokemonSpeciesId { get; set; }

    public virtual Pokedex? Pokedex { get; set; }

    public virtual Pokemonspecy? PokemonSpecies { get; set; }
}
