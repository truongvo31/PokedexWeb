using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Typeefficacypast
{
    public int Id { get; set; }

    public int DamageFactor { get; set; }

    public int? DamageTypeId { get; set; }

    public int? GenerationId { get; set; }

    public int? TargetTypeId { get; set; }

    public virtual Type? DamageType { get; set; }

    public virtual Generation? Generation { get; set; }

    public virtual Type? TargetType { get; set; }
}
