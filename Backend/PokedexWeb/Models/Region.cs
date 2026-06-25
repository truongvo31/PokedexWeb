using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Region
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual Generation? Generation { get; set; }

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();

    public virtual ICollection<Pokedex> Pokedices { get; set; } = new List<Pokedex>();

    public virtual ICollection<Pokemonevolution> Pokemonevolutions { get; set; } = new List<Pokemonevolution>();

    public virtual ICollection<Regionname> Regionnames { get; set; } = new List<Regionname>();

    public virtual ICollection<Versiongroupregion> Versiongroupregions { get; set; } = new List<Versiongroupregion>();
}
