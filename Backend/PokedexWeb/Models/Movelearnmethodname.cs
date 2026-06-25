using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Movelearnmethodname
{
    public int Id { get; set; }

    public int? LanguageId { get; set; }

    public int? MoveLearnMethodId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Language? Language { get; set; }

    public virtual Movelearnmethod? MoveLearnMethod { get; set; }
}
