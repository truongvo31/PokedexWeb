using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Movedamageclassdescription
{
    public int Id { get; set; }

    public int? LanguageId { get; set; }

    public int? MoveDamageClassId { get; set; }

    public string Description { get; set; } = null!;

    public virtual Language? Language { get; set; }

    public virtual Movedamageclass? MoveDamageClass { get; set; }
}
