using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokemonegggroup
{
    public int Id { get; set; }

    public int? EggGroupId { get; set; }

    public int? PokemonSpeciesId { get; set; }

    public virtual Egggroup? EggGroup { get; set; }

    public virtual Pokemonspecy? PokemonSpecies { get; set; }
}
