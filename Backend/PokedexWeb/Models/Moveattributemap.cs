using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Moveattributemap
{
    public int Id { get; set; }

    public int? MoveId { get; set; }

    public int? MoveAttributeId { get; set; }

    public virtual Move? Move { get; set; }

    public virtual Moveattribute? MoveAttribute { get; set; }
}
