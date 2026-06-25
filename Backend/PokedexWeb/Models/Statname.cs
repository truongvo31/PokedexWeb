using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Statname
{
    public int Id { get; set; }

    public int? LanguageId { get; set; }

    public int? StatId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Language? Language { get; set; }

    public virtual Stat? Stat { get; set; }
}
