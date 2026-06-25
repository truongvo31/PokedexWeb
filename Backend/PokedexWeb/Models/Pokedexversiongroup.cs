using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokedexversiongroup
{
    public int Id { get; set; }

    public int? PokedexId { get; set; }

    public int? VersionGroupId { get; set; }

    public virtual Pokedex? Pokedex { get; set; }

    public virtual Versiongroup? VersionGroup { get; set; }
}
