using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokemonhabitat
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Pokemonhabitatname> Pokemonhabitatnames { get; set; } = new List<Pokemonhabitatname>();

    public virtual ICollection<Pokemonspecy> Pokemonspecies { get; set; } = new List<Pokemonspecy>();
}
