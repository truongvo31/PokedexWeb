using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Movechange
{
    public int Id { get; set; }

    public int? Power { get; set; }

    public int? Accuracy { get; set; }

    public int? MoveEffectChance { get; set; }

    public int? MoveId { get; set; }

    public int? MoveEffectId { get; set; }

    public int? TypeId { get; set; }

    public int? VersionGroupId { get; set; }

    public int? Pp { get; set; }

    public virtual Move? Move { get; set; }

    public virtual Moveeffect? MoveEffect { get; set; }

    public virtual Type? Type { get; set; }

    public virtual Versiongroup? VersionGroup { get; set; }
}
