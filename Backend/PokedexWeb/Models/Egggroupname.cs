using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Egggroupname
{
    public int Id { get; set; }

    public int? EggGroupId { get; set; }

    public int? LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Egggroup? EggGroup { get; set; }

    public virtual Language? Language { get; set; }
}
