using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Naturepokeathlonstat
{
    public int Id { get; set; }

    public int MaxChange { get; set; }

    public int? NatureId { get; set; }

    public int? PokeathlonStatId { get; set; }

    public virtual Nature? Nature { get; set; }

    public virtual Pokeathlonstat? PokeathlonStat { get; set; }
}
