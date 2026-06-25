using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Movelearnmethod
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Movelearnmethoddescription> Movelearnmethoddescriptions { get; set; } = new List<Movelearnmethoddescription>();

    public virtual ICollection<Movelearnmethodname> Movelearnmethodnames { get; set; } = new List<Movelearnmethodname>();

    public virtual ICollection<Pokemonmove> Pokemonmoves { get; set; } = new List<Pokemonmove>();

    public virtual ICollection<Versiongroupmovelearnmethod> Versiongroupmovelearnmethods { get; set; } = new List<Versiongroupmovelearnmethod>();
}
