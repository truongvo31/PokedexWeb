using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokemonmove
{
    public int Id { get; set; }

    public int? Order { get; set; }

    public int Level { get; set; }

    public int? MoveId { get; set; }

    public int? PokemonId { get; set; }

    public int? VersionGroupId { get; set; }

    public int? MoveLearnMethodId { get; set; }

    public int? Mastery { get; set; }

    public virtual Move? Move { get; set; }

    public virtual Movelearnmethod? MoveLearnMethod { get; set; }

    public virtual Pokemon? Pokemon { get; set; }

    public virtual Versiongroup? VersionGroup { get; set; }
}
