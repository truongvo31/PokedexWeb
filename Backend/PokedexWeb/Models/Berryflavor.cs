using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Berryflavor
{
    public int Id { get; set; }

    public int? ContestTypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Berryflavormap> Berryflavormaps { get; set; } = new List<Berryflavormap>();

    public virtual ICollection<Berryflavorname> Berryflavornames { get; set; } = new List<Berryflavorname>();

    public virtual Contesttype? ContestType { get; set; }

    public virtual ICollection<Nature> NatureHatesFlavors { get; set; } = new List<Nature>();

    public virtual ICollection<Nature> NatureLikesFlavors { get; set; } = new List<Nature>();
}
