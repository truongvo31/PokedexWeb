using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Berryflavorname
{
    public int Id { get; set; }

    public int? BerryFlavorId { get; set; }

    public int? LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Berryflavor? BerryFlavor { get; set; }

    public virtual Language? Language { get; set; }
}
