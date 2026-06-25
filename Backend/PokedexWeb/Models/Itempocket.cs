using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Itempocket
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Itemcategory> Itemcategories { get; set; } = new List<Itemcategory>();

    public virtual ICollection<Itempocketname> Itempocketnames { get; set; } = new List<Itempocketname>();
}
