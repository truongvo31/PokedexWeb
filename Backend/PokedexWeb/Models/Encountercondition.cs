using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Encountercondition
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Encounterconditionname> Encounterconditionnames { get; set; } = new List<Encounterconditionname>();

    public virtual ICollection<Encounterconditionvalue> Encounterconditionvalues { get; set; } = new List<Encounterconditionvalue>();
}
