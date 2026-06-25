using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Encounter
{
    public int Id { get; set; }

    public int MinLevel { get; set; }

    public int MaxLevel { get; set; }

    public int? LocationAreaId { get; set; }

    public int? PokemonId { get; set; }

    public int? VersionId { get; set; }

    public int? EncounterSlotId { get; set; }

    public virtual Encounterslot? EncounterSlot { get; set; }

    public virtual ICollection<Encounterconditionvaluemap> Encounterconditionvaluemaps { get; set; } = new List<Encounterconditionvaluemap>();

    public virtual Locationarea? LocationArea { get; set; }

    public virtual Pokemon? Pokemon { get; set; }

    public virtual Version? Version { get; set; }
}
