using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Itemattribute
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Itemattributedescription> Itemattributedescriptions { get; set; } = new List<Itemattributedescription>();

    public virtual ICollection<Itemattributemap> Itemattributemaps { get; set; } = new List<Itemattributemap>();

    public virtual ICollection<Itemattributename> Itemattributenames { get; set; } = new List<Itemattributename>();
}
