using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokedexdescription
{
    public int Id { get; set; }

    public int? LanguageId { get; set; }

    public int? PokedexId { get; set; }

    public string Description { get; set; } = null!;

    public virtual Language? Language { get; set; }

    public virtual Pokedex? Pokedex { get; set; }
}
