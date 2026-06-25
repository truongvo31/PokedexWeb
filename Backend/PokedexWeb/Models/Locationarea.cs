using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Locationarea
{
    public int Id { get; set; }

    public int GameIndex { get; set; }

    public int? LocationId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Encounter> Encounters { get; set; } = new List<Encounter>();

    public virtual Location? Location { get; set; }

    public virtual ICollection<Locationareaencounterrate> Locationareaencounterrates { get; set; } = new List<Locationareaencounterrate>();

    public virtual ICollection<Locationareaname> Locationareanames { get; set; } = new List<Locationareaname>();
}
