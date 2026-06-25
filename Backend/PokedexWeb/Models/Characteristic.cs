using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Characteristic
{
    public int Id { get; set; }

    public int GeneMod5 { get; set; }

    public int? StatId { get; set; }

    public virtual ICollection<Characteristicdescription> Characteristicdescriptions { get; set; } = new List<Characteristicdescription>();

    public virtual Stat? Stat { get; set; }
}
