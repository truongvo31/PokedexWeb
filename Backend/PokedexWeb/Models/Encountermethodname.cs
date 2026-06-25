using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Encountermethodname
{
    public int Id { get; set; }

    public int? EncounterMethodId { get; set; }

    public int? LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Encountermethod? EncounterMethod { get; set; }

    public virtual Language? Language { get; set; }
}
