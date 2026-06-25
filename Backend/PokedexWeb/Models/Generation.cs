using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Generation
{
    public int Id { get; set; }

    public int? RegionId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Ability> Abilities { get; set; } = new List<Ability>();

    public virtual ICollection<Generationname> Generationnames { get; set; } = new List<Generationname>();

    public virtual ICollection<Itemgameindex> Itemgameindices { get; set; } = new List<Itemgameindex>();

    public virtual ICollection<Locationgameindex> Locationgameindices { get; set; } = new List<Locationgameindex>();

    public virtual ICollection<Move> Moves { get; set; } = new List<Move>();

    public virtual ICollection<Pokemonabilitypast> Pokemonabilitypasts { get; set; } = new List<Pokemonabilitypast>();

    public virtual ICollection<Pokemonformgeneration> Pokemonformgenerations { get; set; } = new List<Pokemonformgeneration>();

    public virtual ICollection<Pokemonspecy> Pokemonspecies { get; set; } = new List<Pokemonspecy>();

    public virtual ICollection<Pokemonstatpast> Pokemonstatpasts { get; set; } = new List<Pokemonstatpast>();

    public virtual ICollection<Pokemontypepast> Pokemontypepasts { get; set; } = new List<Pokemontypepast>();

    public virtual Region? Region { get; set; }

    public virtual ICollection<Typeefficacypast> Typeefficacypasts { get; set; } = new List<Typeefficacypast>();

    public virtual ICollection<Typegameindex> Typegameindices { get; set; } = new List<Typegameindex>();

    public virtual ICollection<Type> Types { get; set; } = new List<Type>();

    public virtual ICollection<Versiongroup> Versiongroups { get; set; } = new List<Versiongroup>();
}
