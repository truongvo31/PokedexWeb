using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Contesteffect
{
    public int Id { get; set; }

    public int Appeal { get; set; }

    public int Jam { get; set; }

    public virtual ICollection<Contesteffecteffecttext> Contesteffecteffecttexts { get; set; } = new List<Contesteffecteffecttext>();

    public virtual ICollection<Contesteffectflavortext> Contesteffectflavortexts { get; set; } = new List<Contesteffectflavortext>();

    public virtual ICollection<Move> Moves { get; set; } = new List<Move>();
}
