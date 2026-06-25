using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokeathlonstat
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Naturepokeathlonstat> Naturepokeathlonstats { get; set; } = new List<Naturepokeathlonstat>();

    public virtual ICollection<Pokeathlonstatname> Pokeathlonstatnames { get; set; } = new List<Pokeathlonstatname>();
}
