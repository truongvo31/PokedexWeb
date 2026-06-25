using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Movemetum
{
    public int Id { get; set; }

    public int? MinHits { get; set; }

    public int? MaxHits { get; set; }

    public int? MinTurns { get; set; }

    public int? MaxTurns { get; set; }

    public int? CritRate { get; set; }

    public int? AilmentChance { get; set; }

    public int? FlinchChance { get; set; }

    public int? MoveMetaCategoryId { get; set; }

    public int MoveId { get; set; }

    public int? MoveMetaAilmentId { get; set; }

    public int? StatChance { get; set; }

    public int? Drain { get; set; }

    public int? Healing { get; set; }

    public virtual Move Move { get; set; } = null!;

    public virtual Movemetaailment? MoveMetaAilment { get; set; }

    public virtual Movemetacategory? MoveMetaCategory { get; set; }
}
