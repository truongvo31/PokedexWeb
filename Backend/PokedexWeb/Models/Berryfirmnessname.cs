using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Berryfirmnessname
{
    public int Id { get; set; }

    public int? BerryFirmnessId { get; set; }

    public int? LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Berryfirmness? BerryFirmness { get; set; }

    public virtual Language? Language { get; set; }
}
