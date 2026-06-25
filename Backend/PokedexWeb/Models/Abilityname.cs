using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Abilityname
{
    public int Id { get; set; }

    public int? AbilityId { get; set; }

    public int? LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Ability? Ability { get; set; }

    public virtual Language? Language { get; set; }
}
