using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokemonstatpast
{
    public int Id { get; set; }

    public int BaseStat { get; set; }

    public int Effort { get; set; }

    public int? GenerationId { get; set; }

    public int? PokemonId { get; set; }

    public int? StatId { get; set; }

    public virtual Generation? Generation { get; set; }

    public virtual Pokemon? Pokemon { get; set; }

    public virtual Stat? Stat { get; set; }
}
