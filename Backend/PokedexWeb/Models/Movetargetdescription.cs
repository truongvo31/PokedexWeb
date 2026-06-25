using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Movetargetdescription
{
    public int Id { get; set; }

    public int? LanguageId { get; set; }

    public int? MoveTargetId { get; set; }

    public string Description { get; set; } = null!;

    public virtual Language? Language { get; set; }

    public virtual Movetarget? MoveTarget { get; set; }
}
