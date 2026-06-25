using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Location
{
    public int Id { get; set; }

    public int? RegionId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Locationarea> Locationareas { get; set; } = new List<Locationarea>();

    public virtual ICollection<Locationgameindex> Locationgameindices { get; set; } = new List<Locationgameindex>();

    public virtual ICollection<Locationname> Locationnames { get; set; } = new List<Locationname>();

    public virtual ICollection<Pokemonevolution> Pokemonevolutions { get; set; } = new List<Pokemonevolution>();

    public virtual Region? Region { get; set; }
}
