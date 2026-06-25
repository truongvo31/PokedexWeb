using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Growthrate
{
    public int Id { get; set; }

    public string Formula { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<Experience> Experiences { get; set; } = new List<Experience>();

    public virtual ICollection<Growthratedescription> Growthratedescriptions { get; set; } = new List<Growthratedescription>();

    public virtual ICollection<Machine> Machines { get; set; } = new List<Machine>();

    public virtual ICollection<Pokemonspecy> Pokemonspecies { get; set; } = new List<Pokemonspecy>();
}
