using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Locationgameindex
{
    public int Id { get; set; }

    public int GameIndex { get; set; }

    public int? GenerationId { get; set; }

    public int? LocationId { get; set; }

    public virtual Generation? Generation { get; set; }

    public virtual Location? Location { get; set; }
}
