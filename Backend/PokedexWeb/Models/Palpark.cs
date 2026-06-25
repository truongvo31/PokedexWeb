using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Palpark
{
    public int Id { get; set; }

    public int Rate { get; set; }

    public int? PalParkAreaId { get; set; }

    public int? PokemonSpeciesId { get; set; }

    public int? BaseScore { get; set; }

    public virtual Palparkarea? PalParkArea { get; set; }

    public virtual Pokemonspecy? PokemonSpecies { get; set; }
}
