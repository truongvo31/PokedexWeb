using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Moveattribute
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Moveattributedescription> Moveattributedescriptions { get; set; } = new List<Moveattributedescription>();

    public virtual ICollection<Moveattributemap> Moveattributemaps { get; set; } = new List<Moveattributemap>();

    public virtual ICollection<Moveattributename> Moveattributenames { get; set; } = new List<Moveattributename>();
}
