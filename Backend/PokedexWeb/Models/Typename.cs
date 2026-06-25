using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Typename
{
    public int Id { get; set; }

    public int? LanguageId { get; set; }

    public int? TypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Language? Language { get; set; }

    public virtual Type? Type { get; set; }
}
