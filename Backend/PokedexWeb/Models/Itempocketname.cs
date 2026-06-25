using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Itempocketname
{
    public int Id { get; set; }

    public int? ItemPocketId { get; set; }

    public int? LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Itempocket? ItemPocket { get; set; }

    public virtual Language? Language { get; set; }
}
