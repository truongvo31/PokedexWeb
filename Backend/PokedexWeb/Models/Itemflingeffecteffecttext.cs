using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Itemflingeffecteffecttext
{
    public int Id { get; set; }

    public int? ItemFlingEffectId { get; set; }

    public int? LanguageId { get; set; }

    public string Effect { get; set; } = null!;

    public virtual Itemflingeffect? ItemFlingEffect { get; set; }

    public virtual Language? Language { get; set; }
}
