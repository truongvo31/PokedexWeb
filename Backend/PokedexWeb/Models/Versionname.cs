using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Versionname
{
    public int Id { get; set; }

    public int? LanguageId { get; set; }

    public int? VersionId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Language? Language { get; set; }

    public virtual Version? Version { get; set; }
}
