using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Movebattlestylename
{
    public int Id { get; set; }

    public int? LanguageId { get; set; }

    public int? MoveBattleStyleId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Language? Language { get; set; }

    public virtual Movebattlestyle? MoveBattleStyle { get; set; }
}
