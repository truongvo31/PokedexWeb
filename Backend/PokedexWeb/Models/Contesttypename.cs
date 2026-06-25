using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Contesttypename
{
    public int Id { get; set; }

    public string Flavor { get; set; } = null!;

    public string Color { get; set; } = null!;

    public int? ContestTypeId { get; set; }

    public int? LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Contesttype? ContestType { get; set; }

    public virtual Language? Language { get; set; }
}
