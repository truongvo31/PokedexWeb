using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Abilityflavortext
{
    public int Id { get; set; }

    public int? AbilityId { get; set; }

    public int? LanguageId { get; set; }

    public int? VersionGroupId { get; set; }

    public string FlavorText { get; set; } = null!;

    public virtual Ability? Ability { get; set; }

    public virtual Language? Language { get; set; }

    public virtual Versiongroup? VersionGroup { get; set; }
}
