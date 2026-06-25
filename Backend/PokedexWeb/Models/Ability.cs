using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Ability
{
    public int Id { get; set; }

    public bool IsMainSeries { get; set; }

    public int? GenerationId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Abilitychange> Abilitychanges { get; set; } = new List<Abilitychange>();

    public virtual ICollection<Abilityeffecttext> Abilityeffecttexts { get; set; } = new List<Abilityeffecttext>();

    public virtual ICollection<Abilityflavortext> Abilityflavortexts { get; set; } = new List<Abilityflavortext>();

    public virtual ICollection<Abilityname> Abilitynames { get; set; } = new List<Abilityname>();

    public virtual Generation? Generation { get; set; }

    public virtual ICollection<Pokemonability> Pokemonabilities { get; set; } = new List<Pokemonability>();

    public virtual ICollection<Pokemonabilitypast> Pokemonabilitypasts { get; set; } = new List<Pokemonabilitypast>();
}
