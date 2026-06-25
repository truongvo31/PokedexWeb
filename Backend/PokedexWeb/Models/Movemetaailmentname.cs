using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Movemetaailmentname
{
    public int Id { get; set; }

    public int? LanguageId { get; set; }

    public int? MoveMetaAilmentId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Language? Language { get; set; }

    public virtual Movemetaailment? MoveMetaAilment { get; set; }
}
