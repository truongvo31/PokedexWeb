using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Movebattlestyle
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Movebattlestylename> Movebattlestylenames { get; set; } = new List<Movebattlestylename>();

    public virtual ICollection<Naturebattlestylepreference> Naturebattlestylepreferences { get; set; } = new List<Naturebattlestylepreference>();
}
