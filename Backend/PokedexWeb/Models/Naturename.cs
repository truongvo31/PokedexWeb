using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Naturename
{
    public int Id { get; set; }

    public int? LanguageId { get; set; }

    public int? NatureId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Language? Language { get; set; }

    public virtual Nature? Nature { get; set; }
}
