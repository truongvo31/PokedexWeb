using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokedex
{
    public int Id { get; set; }

    public bool IsMainSeries { get; set; }

    public int? RegionId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Pokedexdescription> Pokedexdescriptions { get; set; } = new List<Pokedexdescription>();

    public virtual ICollection<Pokedexname> Pokedexnames { get; set; } = new List<Pokedexname>();

    public virtual ICollection<Pokedexversiongroup> Pokedexversiongroups { get; set; } = new List<Pokedexversiongroup>();

    public virtual ICollection<Pokemondexnumber> Pokemondexnumbers { get; set; } = new List<Pokemondexnumber>();

    public virtual Region? Region { get; set; }
}
