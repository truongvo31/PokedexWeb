using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Berryflavormap
{
    public int Id { get; set; }

    public int Potency { get; set; }

    public int? BerryId { get; set; }

    public int? BerryFlavorId { get; set; }

    public virtual Berry? Berry { get; set; }

    public virtual Berryflavor? BerryFlavor { get; set; }
}
