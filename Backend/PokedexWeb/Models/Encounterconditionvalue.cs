using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Encounterconditionvalue
{
    public int Id { get; set; }

    public bool IsDefault { get; set; }

    public int? EncounterConditionId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Encountercondition? EncounterCondition { get; set; }

    public virtual ICollection<Encounterconditionvaluemap> Encounterconditionvaluemaps { get; set; } = new List<Encounterconditionvaluemap>();

    public virtual ICollection<Encounterconditionvaluename> Encounterconditionvaluenames { get; set; } = new List<Encounterconditionvaluename>();
}
