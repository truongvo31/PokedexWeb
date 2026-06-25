using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Encounterconditionvaluemap
{
    public int Id { get; set; }

    public int? EncounterId { get; set; }

    public int? EncounterConditionValueId { get; set; }

    public virtual Encounter? Encounter { get; set; }

    public virtual Encounterconditionvalue? EncounterConditionValue { get; set; }
}
