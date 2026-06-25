using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Itemattributemap
{
    public int Id { get; set; }

    public int? ItemId { get; set; }

    public int? ItemAttributeId { get; set; }

    public virtual Item? Item { get; set; }

    public virtual Itemattribute? ItemAttribute { get; set; }
}
