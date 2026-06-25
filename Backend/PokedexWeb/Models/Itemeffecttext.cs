using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Itemeffecttext
{
    public int Id { get; set; }

    public string Effect { get; set; } = null!;

    public string ShortEffect { get; set; } = null!;

    public int? ItemId { get; set; }

    public int? LanguageId { get; set; }

    public virtual Item? Item { get; set; }

    public virtual Language? Language { get; set; }
}
