using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Movetarget
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Move> Moves { get; set; } = new List<Move>();

    public virtual ICollection<Movetargetdescription> Movetargetdescriptions { get; set; } = new List<Movetargetdescription>();

    public virtual ICollection<Movetargetname> Movetargetnames { get; set; } = new List<Movetargetname>();
}
