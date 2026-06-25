using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Experience
{
    public int Id { get; set; }

    public int Level { get; set; }

    public int Experience1 { get; set; }

    public int? GrowthRateId { get; set; }

    public virtual Growthrate? GrowthRate { get; set; }
}
