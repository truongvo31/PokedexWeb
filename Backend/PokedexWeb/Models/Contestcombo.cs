using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Contestcombo
{
    public int Id { get; set; }

    public int? FirstMoveId { get; set; }

    public int? SecondMoveId { get; set; }

    public virtual Move? FirstMove { get; set; }

    public virtual Move? SecondMove { get; set; }
}
