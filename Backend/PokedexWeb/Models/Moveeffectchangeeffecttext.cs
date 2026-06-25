using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Moveeffectchangeeffecttext
{
    public int Id { get; set; }

    public string Effect { get; set; } = null!;

    public int? LanguageId { get; set; }

    public int? MoveEffectChangeId { get; set; }

    public virtual Language? Language { get; set; }

    public virtual Moveeffectchange? MoveEffectChange { get; set; }
}
