using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Moveattributedescription
{
    public int Id { get; set; }

    public int? LanguageId { get; set; }

    public int? MoveAttributeId { get; set; }

    public string Description { get; set; } = null!;

    public virtual Language? Language { get; set; }

    public virtual Moveattribute? MoveAttribute { get; set; }
}
