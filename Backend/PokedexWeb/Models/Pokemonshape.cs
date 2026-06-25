using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokemonshape
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Pokemonshapename> Pokemonshapenames { get; set; } = new List<Pokemonshapename>();

    public virtual ICollection<Pokemonspecy> Pokemonspecies { get; set; } = new List<Pokemonspecy>();
}
