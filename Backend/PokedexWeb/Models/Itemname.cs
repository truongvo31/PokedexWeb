using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Itemname
{
    public int Id { get; set; }

    public int? ItemId { get; set; }

    public int? LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Item? Item { get; set; }

    public virtual Language? Language { get; set; }
}
