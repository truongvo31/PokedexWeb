using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Supercontesteffectflavortext
{
    public int Id { get; set; }

    public string FlavorText { get; set; } = null!;

    public int? LanguageId { get; set; }

    public int? SuperContestEffectId { get; set; }

    public virtual Language? Language { get; set; }

    public virtual Supercontesteffect? SuperContestEffect { get; set; }
}
