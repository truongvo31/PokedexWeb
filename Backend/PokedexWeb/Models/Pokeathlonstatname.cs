using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokeathlonstatname
{
    public int Id { get; set; }

    public int? LanguageId { get; set; }

    public int? PokeathlonStatId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Language? Language { get; set; }

    public virtual Pokeathlonstat? PokeathlonStat { get; set; }
}
