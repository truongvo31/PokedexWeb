using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Locationareaencounterrate
{
    public int Id { get; set; }

    public int Rate { get; set; }

    public int? LocationAreaId { get; set; }

    public int? VersionId { get; set; }

    public int? EncounterMethodId { get; set; }

    public virtual Encountermethod? EncounterMethod { get; set; }

    public virtual Locationarea? LocationArea { get; set; }

    public virtual Version? Version { get; set; }
}
