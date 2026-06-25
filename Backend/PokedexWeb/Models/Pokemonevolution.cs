using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokemonevolution
{
    public int Id { get; set; }

    public int? MinLevel { get; set; }

    public string? TimeOfDay { get; set; }

    public int? MinHappiness { get; set; }

    public int? MinAffection { get; set; }

    public int? RelativePhysicalStats { get; set; }

    public bool NeedsOverworldRain { get; set; }

    public bool TurnUpsideDown { get; set; }

    public int? EvolutionTriggerId { get; set; }

    public int? EvolvedSpeciesId { get; set; }

    public int? GenderId { get; set; }

    public int? KnownMoveId { get; set; }

    public int? KnownMoveTypeId { get; set; }

    public int? PartySpeciesId { get; set; }

    public int? PartyTypeId { get; set; }

    public int? TradeSpeciesId { get; set; }

    public int? MinBeauty { get; set; }

    public int? EvolutionItemId { get; set; }

    public int? HeldItemId { get; set; }

    public int? LocationId { get; set; }

    public int? RegionId { get; set; }

    public int? MinMoveCount { get; set; }

    public int? MinSteps { get; set; }

    public bool NeedsMultiplayer { get; set; }

    public int? UsedMoveId { get; set; }

    public int? MinDamageTaken { get; set; }

    public int? BaseFormId { get; set; }

    public virtual Pokemon? BaseForm { get; set; }

    public virtual Item? EvolutionItem { get; set; }

    public virtual Evolutiontrigger? EvolutionTrigger { get; set; }

    public virtual Pokemonspecy? EvolvedSpecies { get; set; }

    public virtual Gender? Gender { get; set; }

    public virtual Item? HeldItem { get; set; }

    public virtual Move? KnownMove { get; set; }

    public virtual Type? KnownMoveType { get; set; }

    public virtual Location? Location { get; set; }

    public virtual Pokemonspecy? PartySpecies { get; set; }

    public virtual Type? PartyType { get; set; }

    public virtual Region? Region { get; set; }

    public virtual Pokemonspecy? TradeSpecies { get; set; }

    public virtual Move? UsedMove { get; set; }
}
