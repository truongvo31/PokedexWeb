using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Locationareaname
{
    public int Id { get; set; }

    public int? LanguageId { get; set; }

    public int? LocationAreaId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Language? Language { get; set; }

    public virtual Locationarea? LocationArea { get; set; }
}
