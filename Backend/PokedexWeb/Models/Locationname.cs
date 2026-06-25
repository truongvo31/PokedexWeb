using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Locationname
{
    public int Id { get; set; }

    public int? LanguageId { get; set; }

    public int? LocationId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Language? Language { get; set; }

    public virtual Location? Location { get; set; }
}
