using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Abilityeffecttext
{
    public int Id { get; set; }

    public string Effect { get; set; } = null!;

    public string ShortEffect { get; set; } = null!;

    public int? AbilityId { get; set; }

    public int? LanguageId { get; set; }

    public virtual Ability? Ability { get; set; }

    public virtual Language? Language { get; set; }
}
