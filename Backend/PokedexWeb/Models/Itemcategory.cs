using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Itemcategory
{
    public int Id { get; set; }

    public int? ItemPocketId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Itempocket? ItemPocket { get; set; }

    public virtual ICollection<Itemcategoryname> Itemcategorynames { get; set; } = new List<Itemcategoryname>();

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();
}
