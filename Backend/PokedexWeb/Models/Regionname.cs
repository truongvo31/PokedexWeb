using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Regionname
{
    public int Id { get; set; }

    public int? LanguageId { get; set; }

    public int? RegionId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Language? Language { get; set; }

    public virtual Region? Region { get; set; }
}
