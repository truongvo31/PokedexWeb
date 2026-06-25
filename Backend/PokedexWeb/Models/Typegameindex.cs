using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Typegameindex
{
    public int Id { get; set; }

    public int GameIndex { get; set; }

    public int? GenerationId { get; set; }

    public int? TypeId { get; set; }

    public virtual Generation? Generation { get; set; }

    public virtual Type? Type { get; set; }
}
