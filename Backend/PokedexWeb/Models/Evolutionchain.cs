using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Evolutionchain
{
    public int Id { get; set; }

    public int? BabyTriggerItemId { get; set; }

    public virtual Item? BabyTriggerItem { get; set; }

    public virtual ICollection<Pokemonspecy> Pokemonspecies { get; set; } = new List<Pokemonspecy>();
}
