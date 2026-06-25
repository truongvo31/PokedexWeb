using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Naturebattlestylepreference
{
    public int Id { get; set; }

    public int LowHpPreference { get; set; }

    public int HighHpPreference { get; set; }

    public int? NatureId { get; set; }

    public int? MoveBattleStyleId { get; set; }

    public virtual Movebattlestyle? MoveBattleStyle { get; set; }

    public virtual Nature? Nature { get; set; }
}
