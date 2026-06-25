using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Encounterslot
{
    public int Id { get; set; }

    public int? Slot { get; set; }

    public int Rarity { get; set; }

    public int? EncounterMethodId { get; set; }

    public int? VersionGroupId { get; set; }

    public virtual Encountermethod? EncounterMethod { get; set; }

    public virtual ICollection<Encounter> Encounters { get; set; } = new List<Encounter>();

    public virtual Versiongroup? VersionGroup { get; set; }
}
