using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Palparkarea
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Palparkareaname> Palparkareanames { get; set; } = new List<Palparkareaname>();

    public virtual ICollection<Palpark> Palparks { get; set; } = new List<Palpark>();
}
