using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Moveeffecteffecttext
{
    public int Id { get; set; }

    public string Effect { get; set; } = null!;

    public string ShortEffect { get; set; } = null!;

    public int? LanguageId { get; set; }

    public int? MoveEffectId { get; set; }

    public virtual Language? Language { get; set; }

    public virtual Moveeffect? MoveEffect { get; set; }
}
