using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Machine
{
    public int Id { get; set; }

    public int MachineNumber { get; set; }

    public int? GrowthRateId { get; set; }

    public int? MoveId { get; set; }

    public int? VersionGroupId { get; set; }

    public int? ItemId { get; set; }

    public virtual Growthrate? GrowthRate { get; set; }

    public virtual Item? Item { get; set; }

    public virtual Move? Move { get; set; }

    public virtual Versiongroup? VersionGroup { get; set; }
}
