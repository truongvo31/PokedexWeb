using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokemonformgeneration
{
    public int Id { get; set; }

    public int GameIndex { get; set; }

    public int? GenerationId { get; set; }

    public int? PokemonFormId { get; set; }

    public virtual Generation? Generation { get; set; }

    public virtual Pokemonform? PokemonForm { get; set; }
}
