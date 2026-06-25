using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Generationname
{
    public int Id { get; set; }

    public int? GenerationId { get; set; }

    public int? LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Generation? Generation { get; set; }

    public virtual Language? Language { get; set; }
}
