using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Movedamageclass
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Movedamageclassdescription> Movedamageclassdescriptions { get; set; } = new List<Movedamageclassdescription>();

    public virtual ICollection<Movedamageclassname> Movedamageclassnames { get; set; } = new List<Movedamageclassname>();

    public virtual ICollection<Move> Moves { get; set; } = new List<Move>();

    public virtual ICollection<Stat> Stats { get; set; } = new List<Stat>();

    public virtual ICollection<Type> Types { get; set; } = new List<Type>();
}
