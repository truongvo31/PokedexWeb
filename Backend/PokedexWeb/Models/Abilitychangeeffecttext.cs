using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Abilitychangeeffecttext
{
    public int Id { get; set; }

    public string Effect { get; set; } = null!;

    public int? AbilityChangeId { get; set; }

    public int? LanguageId { get; set; }

    public virtual Abilitychange? AbilityChange { get; set; }

    public virtual Language? Language { get; set; }
}
