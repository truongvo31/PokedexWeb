using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokemonshapename
{
    public int Id { get; set; }

    public string AwesomeName { get; set; } = null!;

    public int? LanguageId { get; set; }

    public int? PokemonShapeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Language? Language { get; set; }

    public virtual Pokemonshape? PokemonShape { get; set; }
}
