using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Versiongroup
{
    public int Id { get; set; }

    public int? Order { get; set; }

    public int? GenerationId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Abilitychange> Abilitychanges { get; set; } = new List<Abilitychange>();

    public virtual ICollection<Abilityflavortext> Abilityflavortexts { get; set; } = new List<Abilityflavortext>();

    public virtual ICollection<Encounterslot> Encounterslots { get; set; } = new List<Encounterslot>();

    public virtual Generation? Generation { get; set; }

    public virtual ICollection<Itemflavortext> Itemflavortexts { get; set; } = new List<Itemflavortext>();

    public virtual ICollection<Machine> Machines { get; set; } = new List<Machine>();

    public virtual ICollection<Movechange> Movechanges { get; set; } = new List<Movechange>();

    public virtual ICollection<Moveeffectchange> Moveeffectchanges { get; set; } = new List<Moveeffectchange>();

    public virtual ICollection<Moveflavortext> Moveflavortexts { get; set; } = new List<Moveflavortext>();

    public virtual ICollection<Pokedexversiongroup> Pokedexversiongroups { get; set; } = new List<Pokedexversiongroup>();

    public virtual ICollection<Pokemonform> Pokemonforms { get; set; } = new List<Pokemonform>();

    public virtual ICollection<Pokemonmove> Pokemonmoves { get; set; } = new List<Pokemonmove>();

    public virtual ICollection<Versiongroupmovelearnmethod> Versiongroupmovelearnmethods { get; set; } = new List<Versiongroupmovelearnmethod>();

    public virtual ICollection<Versiongroupregion> Versiongroupregions { get; set; } = new List<Versiongroupregion>();

    public virtual ICollection<Version> Versions { get; set; } = new List<Version>();
}
