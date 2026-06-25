using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Movemetacategorydescription
{
    public int Id { get; set; }

    public int? LanguageId { get; set; }

    public int? MoveMetaCategoryId { get; set; }

    public string Description { get; set; } = null!;

    public virtual Language? Language { get; set; }

    public virtual Movemetacategory? MoveMetaCategory { get; set; }
}
