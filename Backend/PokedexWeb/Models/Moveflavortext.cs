using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Moveflavortext
{
    public int Id { get; set; }

    public string FlavorText { get; set; } = null!;

    public int? LanguageId { get; set; }

    public int? MoveId { get; set; }

    public int? VersionGroupId { get; set; }

    public virtual Language? Language { get; set; }

    public virtual Move? Move { get; set; }

    public virtual Versiongroup? VersionGroup { get; set; }
}
