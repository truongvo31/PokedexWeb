using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Encounterconditionname
{
    public int Id { get; set; }

    public int? EncounterConditionId { get; set; }

    public int? LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Encountercondition? EncounterCondition { get; set; }

    public virtual Language? Language { get; set; }
}
