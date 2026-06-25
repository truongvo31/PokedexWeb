using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Supercontesteffect
{
    public int Id { get; set; }

    public int Appeal { get; set; }

    public virtual ICollection<Move> Moves { get; set; } = new List<Move>();

    public virtual ICollection<Supercontesteffectflavortext> Supercontesteffectflavortexts { get; set; } = new List<Supercontesteffectflavortext>();
}
