using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokedexname
{
    public int Id { get; set; }

    public int? LanguageId { get; set; }

    public int? PokedexId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Language? Language { get; set; }

    public virtual Pokedex? Pokedex { get; set; }
}
