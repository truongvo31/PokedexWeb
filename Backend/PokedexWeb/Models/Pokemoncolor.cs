using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokemoncolor
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Pokemoncolorname> Pokemoncolornames { get; set; } = new List<Pokemoncolorname>();

    public virtual ICollection<Pokemonspecy> Pokemonspecies { get; set; } = new List<Pokemonspecy>();
}
