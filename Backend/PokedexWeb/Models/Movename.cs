using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Movename
{
    public int Id { get; set; }

    public int? LanguageId { get; set; }

    public int? MoveId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Language? Language { get; set; }

    public virtual Move? Move { get; set; }
}
