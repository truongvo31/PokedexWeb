using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Itemflingeffect
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Itemflingeffecteffecttext> Itemflingeffecteffecttexts { get; set; } = new List<Itemflingeffecteffecttext>();

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();
}
