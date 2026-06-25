using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Versiongroupmovelearnmethod
{
    public int Id { get; set; }

    public int? MoveLearnMethodId { get; set; }

    public int? VersionGroupId { get; set; }

    public virtual Movelearnmethod? MoveLearnMethod { get; set; }

    public virtual Versiongroup? VersionGroup { get; set; }
}
