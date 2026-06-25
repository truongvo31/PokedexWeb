using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Egggroup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Egggroupname> Egggroupnames { get; set; } = new List<Egggroupname>();

    public virtual ICollection<Pokemonegggroup> Pokemonegggroups { get; set; } = new List<Pokemonegggroup>();
}
