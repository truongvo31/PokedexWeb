using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Palparkareaname
{
    public int Id { get; set; }

    public int? LanguageId { get; set; }

    public int? PalParkAreaId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Language? Language { get; set; }

    public virtual Palparkarea? PalParkArea { get; set; }
}
