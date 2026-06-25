using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Movemetastatchange
{
    public int Id { get; set; }

    public int Change { get; set; }

    public int? MoveId { get; set; }

    public int? StatId { get; set; }

    public virtual Move? Move { get; set; }

    public virtual Stat? Stat { get; set; }
}
