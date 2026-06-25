using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Moveeffect
{
    public int Id { get; set; }

    public virtual ICollection<Movechange> Movechanges { get; set; } = new List<Movechange>();

    public virtual ICollection<Moveeffectchange> Moveeffectchanges { get; set; } = new List<Moveeffectchange>();

    public virtual ICollection<Moveeffecteffecttext> Moveeffecteffecttexts { get; set; } = new List<Moveeffecteffecttext>();

    public virtual ICollection<Move> Moves { get; set; } = new List<Move>();
}
