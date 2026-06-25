using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Itemgameindex
{
    public int Id { get; set; }

    public int GameIndex { get; set; }

    public int? GenerationId { get; set; }

    public int? ItemId { get; set; }

    public virtual Generation? Generation { get; set; }

    public virtual Item? Item { get; set; }
}
