using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokemonitem
{
    public int Id { get; set; }

    public int Rarity { get; set; }

    public int? PokemonId { get; set; }

    public int? VersionId { get; set; }

    public int? ItemId { get; set; }

    public virtual Item? Item { get; set; }

    public virtual Pokemon? Pokemon { get; set; }

    public virtual Version? Version { get; set; }
}
