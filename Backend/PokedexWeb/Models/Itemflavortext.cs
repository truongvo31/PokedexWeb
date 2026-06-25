using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Itemflavortext
{
    public int Id { get; set; }

    public string FlavorText { get; set; } = null!;

    public int? ItemId { get; set; }

    public int? LanguageId { get; set; }

    public int? VersionGroupId { get; set; }

    public virtual Item? Item { get; set; }

    public virtual Language? Language { get; set; }

    public virtual Versiongroup? VersionGroup { get; set; }
}
