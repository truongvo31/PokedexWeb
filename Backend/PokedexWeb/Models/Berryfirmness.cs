using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Berryfirmness
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Berry> Berries { get; set; } = new List<Berry>();

    public virtual ICollection<Berryfirmnessname> Berryfirmnessnames { get; set; } = new List<Berryfirmnessname>();
}
