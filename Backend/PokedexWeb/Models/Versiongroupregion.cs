using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Versiongroupregion
{
    public int Id { get; set; }

    public int? VersionGroupId { get; set; }

    public int? RegionId { get; set; }

    public virtual Region? Region { get; set; }

    public virtual Versiongroup? VersionGroup { get; set; }
}
