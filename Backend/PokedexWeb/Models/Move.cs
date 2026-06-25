using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Move
{
    public int Id { get; set; }

    public int? Power { get; set; }

    public int? Pp { get; set; }

    public int? Accuracy { get; set; }

    public int? Priority { get; set; }

    public int? MoveEffectChance { get; set; }

    public int? GenerationId { get; set; }

    public int? MoveDamageClassId { get; set; }

    public int? MoveEffectId { get; set; }

    public int? MoveTargetId { get; set; }

    public int? TypeId { get; set; }

    public int? ContestEffectId { get; set; }

    public int? ContestTypeId { get; set; }

    public int? SuperContestEffectId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Contesteffect? ContestEffect { get; set; }

    public virtual Contesttype? ContestType { get; set; }

    public virtual ICollection<Contestcombo> ContestcomboFirstMoves { get; set; } = new List<Contestcombo>();

    public virtual ICollection<Contestcombo> ContestcomboSecondMoves { get; set; } = new List<Contestcombo>();

    public virtual Generation? Generation { get; set; }

    public virtual ICollection<Machine> Machines { get; set; } = new List<Machine>();

    public virtual Movedamageclass? MoveDamageClass { get; set; }

    public virtual Moveeffect? MoveEffect { get; set; }

    public virtual Movetarget? MoveTarget { get; set; }

    public virtual ICollection<Moveattributemap> Moveattributemaps { get; set; } = new List<Moveattributemap>();

    public virtual ICollection<Movechange> Movechanges { get; set; } = new List<Movechange>();

    public virtual ICollection<Moveflavortext> Moveflavortexts { get; set; } = new List<Moveflavortext>();

    public virtual ICollection<Movemetastatchange> Movemetastatchanges { get; set; } = new List<Movemetastatchange>();

    public virtual Movemetum? Movemetum { get; set; }

    public virtual ICollection<Movename> Movenames { get; set; } = new List<Movename>();

    public virtual ICollection<Pokemonevolution> PokemonevolutionKnownMoves { get; set; } = new List<Pokemonevolution>();

    public virtual ICollection<Pokemonevolution> PokemonevolutionUsedMoves { get; set; } = new List<Pokemonevolution>();

    public virtual ICollection<Pokemonmove> Pokemonmoves { get; set; } = new List<Pokemonmove>();

    public virtual Supercontesteffect? SuperContestEffect { get; set; }

    public virtual ICollection<Supercontestcombo> SupercontestcomboFirstMoves { get; set; } = new List<Supercontestcombo>();

    public virtual ICollection<Supercontestcombo> SupercontestcomboSecondMoves { get; set; } = new List<Supercontestcombo>();

    public virtual Type? Type { get; set; }
}
