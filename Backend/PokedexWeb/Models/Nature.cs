using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Nature
{
    public int Id { get; set; }

    public int GameIndex { get; set; }

    public int? DecreasedStatId { get; set; }

    public int? IncreasedStatId { get; set; }

    public int? HatesFlavorId { get; set; }

    public int? LikesFlavorId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Stat? DecreasedStat { get; set; }

    public virtual Berryflavor? HatesFlavor { get; set; }

    public virtual Stat? IncreasedStat { get; set; }

    public virtual Berryflavor? LikesFlavor { get; set; }

    public virtual ICollection<Naturebattlestylepreference> Naturebattlestylepreferences { get; set; } = new List<Naturebattlestylepreference>();

    public virtual ICollection<Naturename> Naturenames { get; set; } = new List<Naturename>();

    public virtual ICollection<Naturepokeathlonstat> Naturepokeathlonstats { get; set; } = new List<Naturepokeathlonstat>();
}
