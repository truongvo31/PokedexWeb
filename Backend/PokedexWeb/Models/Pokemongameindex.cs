using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokemongameindex
{
    public int Id { get; set; }

    public int GameIndex { get; set; }

    public int? PokemonId { get; set; }

    public int? VersionId { get; set; }

    public virtual Pokemon? Pokemon { get; set; }

    public virtual Version? Version { get; set; }
}
