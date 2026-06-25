using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Encountermethod
{
    public int Id { get; set; }

    public int? Order { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Encountermethodname> Encountermethodnames { get; set; } = new List<Encountermethodname>();

    public virtual ICollection<Encounterslot> Encounterslots { get; set; } = new List<Encounterslot>();

    public virtual ICollection<Locationareaencounterrate> Locationareaencounterrates { get; set; } = new List<Locationareaencounterrate>();
}
