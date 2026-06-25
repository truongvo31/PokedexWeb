using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Evolutiontriggername
{
    public int Id { get; set; }

    public int? EvolutionTriggerId { get; set; }

    public int? LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Evolutiontrigger? EvolutionTrigger { get; set; }

    public virtual Language? Language { get; set; }
}
