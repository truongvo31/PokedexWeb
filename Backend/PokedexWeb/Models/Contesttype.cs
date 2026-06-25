using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Contesttype
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual Berryflavor? Berryflavor { get; set; }

    public virtual ICollection<Contesttypename> Contesttypenames { get; set; } = new List<Contesttypename>();

    public virtual ICollection<Move> Moves { get; set; } = new List<Move>();
}
