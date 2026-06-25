using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Itemcategoryname
{
    public int Id { get; set; }

    public int? ItemCategoryId { get; set; }

    public int? LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Itemcategory? ItemCategory { get; set; }

    public virtual Language? Language { get; set; }
}
