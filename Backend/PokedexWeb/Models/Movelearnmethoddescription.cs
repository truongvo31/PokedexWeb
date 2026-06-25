using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Movelearnmethoddescription
{
    public int Id { get; set; }

    public int? LanguageId { get; set; }

    public int? MoveLearnMethodId { get; set; }

    public string Description { get; set; } = null!;

    public virtual Language? Language { get; set; }

    public virtual Movelearnmethod? MoveLearnMethod { get; set; }
}
