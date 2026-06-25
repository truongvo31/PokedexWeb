using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Gender
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Pokemonevolution> Pokemonevolutions { get; set; } = new List<Pokemonevolution>();
}
