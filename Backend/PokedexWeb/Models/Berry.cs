using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Berry
{
    public int Id { get; set; }

    public int NaturalGiftPower { get; set; }

    public int Size { get; set; }

    public int MaxHarvest { get; set; }

    public int GrowthTime { get; set; }

    public int SoilDryness { get; set; }

    public int Smoothness { get; set; }

    public int? BerryFirmnessId { get; set; }

    public int? ItemId { get; set; }

    public int? NaturalGiftTypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Berryfirmness? BerryFirmness { get; set; }

    public virtual ICollection<Berryflavormap> Berryflavormaps { get; set; } = new List<Berryflavormap>();

    public virtual Item? Item { get; set; }

    public virtual Type? NaturalGiftType { get; set; }
}
