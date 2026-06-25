using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Itemattributename
{
    public int Id { get; set; }

    public int? ItemAttributeId { get; set; }

    public int? LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Itemattribute? ItemAttribute { get; set; }

    public virtual Language? Language { get; set; }
}
