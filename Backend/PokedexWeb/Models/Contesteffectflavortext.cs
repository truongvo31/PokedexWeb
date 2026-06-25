using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Contesteffectflavortext
{
    public int Id { get; set; }

    public string FlavorText { get; set; } = null!;

    public int? ContestEffectId { get; set; }

    public int? LanguageId { get; set; }

    public virtual Contesteffect? ContestEffect { get; set; }

    public virtual Language? Language { get; set; }
}
