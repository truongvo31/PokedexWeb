using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Stat
{
    public int Id { get; set; }

    public bool IsBattleOnly { get; set; }

    public int GameIndex { get; set; }

    public int? MoveDamageClassId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Characteristic> Characteristics { get; set; } = new List<Characteristic>();

    public virtual Movedamageclass? MoveDamageClass { get; set; }

    public virtual ICollection<Movemetastatchange> Movemetastatchanges { get; set; } = new List<Movemetastatchange>();

    public virtual ICollection<Nature> NatureDecreasedStats { get; set; } = new List<Nature>();

    public virtual ICollection<Nature> NatureIncreasedStats { get; set; } = new List<Nature>();

    public virtual ICollection<Pokemonstatpast> Pokemonstatpasts { get; set; } = new List<Pokemonstatpast>();

    public virtual ICollection<Pokemonstat> Pokemonstats { get; set; } = new List<Pokemonstat>();

    public virtual ICollection<Statname> Statnames { get; set; } = new List<Statname>();
}
