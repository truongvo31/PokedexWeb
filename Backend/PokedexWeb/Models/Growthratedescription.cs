using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Growthratedescription
{
    public int Id { get; set; }

    public int? GrowthRateId { get; set; }

    public int? LanguageId { get; set; }

    public string Description { get; set; } = null!;

    public virtual Growthrate? GrowthRate { get; set; }

    public virtual Language? Language { get; set; }
}
