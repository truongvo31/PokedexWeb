using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Encounterconditionvaluename
{
    public int Id { get; set; }

    public int? EncounterConditionValueId { get; set; }

    public int? LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Encounterconditionvalue? EncounterConditionValue { get; set; }

    public virtual Language? Language { get; set; }
}
