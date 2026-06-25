using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Type
{
    public int Id { get; set; }

    public int? GenerationId { get; set; }

    public int? MoveDamageClassId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Berry> Berries { get; set; } = new List<Berry>();

    public virtual Generation? Generation { get; set; }

    public virtual Movedamageclass? MoveDamageClass { get; set; }

    public virtual ICollection<Movechange> Movechanges { get; set; } = new List<Movechange>();

    public virtual ICollection<Move> Moves { get; set; } = new List<Move>();

    public virtual ICollection<Pokemonevolution> PokemonevolutionKnownMoveTypes { get; set; } = new List<Pokemonevolution>();

    public virtual ICollection<Pokemonevolution> PokemonevolutionPartyTypes { get; set; } = new List<Pokemonevolution>();

    public virtual ICollection<Pokemonformtype> Pokemonformtypes { get; set; } = new List<Pokemonformtype>();

    public virtual ICollection<Pokemontypepast> Pokemontypepasts { get; set; } = new List<Pokemontypepast>();

    public virtual ICollection<Pokemontype> Pokemontypes { get; set; } = new List<Pokemontype>();

    public virtual ICollection<Typeefficacy> TypeefficacyDamageTypes { get; set; } = new List<Typeefficacy>();

    public virtual ICollection<Typeefficacy> TypeefficacyTargetTypes { get; set; } = new List<Typeefficacy>();

    public virtual ICollection<Typeefficacypast> TypeefficacypastDamageTypes { get; set; } = new List<Typeefficacypast>();

    public virtual ICollection<Typeefficacypast> TypeefficacypastTargetTypes { get; set; } = new List<Typeefficacypast>();

    public virtual ICollection<Typegameindex> Typegameindices { get; set; } = new List<Typegameindex>();

    public virtual ICollection<Typename> Typenames { get; set; } = new List<Typename>();
}
