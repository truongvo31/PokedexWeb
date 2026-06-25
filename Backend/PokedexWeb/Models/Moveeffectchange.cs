using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Moveeffectchange
{
    public int Id { get; set; }

    public int? MoveEffectId { get; set; }

    public int? VersionGroupId { get; set; }

    public virtual Moveeffect? MoveEffect { get; set; }

    public virtual ICollection<Moveeffectchangeeffecttext> Moveeffectchangeeffecttexts { get; set; } = new List<Moveeffectchangeeffecttext>();

    public virtual Versiongroup? VersionGroup { get; set; }
}
