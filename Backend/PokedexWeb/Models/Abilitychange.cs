using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Abilitychange
{
    public int Id { get; set; }

    public int? AbilityId { get; set; }

    public int? VersionGroupId { get; set; }

    public virtual Ability? Ability { get; set; }

    public virtual ICollection<Abilitychangeeffecttext> Abilitychangeeffecttexts { get; set; } = new List<Abilitychangeeffecttext>();

    public virtual Versiongroup? VersionGroup { get; set; }
}
