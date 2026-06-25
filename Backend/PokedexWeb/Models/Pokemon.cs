using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokemon
{
    public int Id { get; set; }

    public int? Order { get; set; }

    public int? Height { get; set; }

    public int? Weight { get; set; }

    public int? BaseExperience { get; set; }

    public bool IsDefault { get; set; }

    public int? PokemonSpeciesId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Encounter> Encounters { get; set; } = new List<Encounter>();

    public virtual Pokemonspecy? PokemonSpecies { get; set; }

    public virtual ICollection<Pokemonability> Pokemonabilities { get; set; } = new List<Pokemonability>();

    public virtual ICollection<Pokemonabilitypast> Pokemonabilitypasts { get; set; } = new List<Pokemonabilitypast>();

    public virtual ICollection<Pokemoncry> Pokemoncries { get; set; } = new List<Pokemoncry>();

    public virtual ICollection<Pokemonevolution> Pokemonevolutions { get; set; } = new List<Pokemonevolution>();

    public virtual ICollection<Pokemonform> Pokemonforms { get; set; } = new List<Pokemonform>();

    public virtual ICollection<Pokemongameindex> Pokemongameindices { get; set; } = new List<Pokemongameindex>();

    public virtual ICollection<Pokemonitem> Pokemonitems { get; set; } = new List<Pokemonitem>();

    public virtual ICollection<Pokemonmove> Pokemonmoves { get; set; } = new List<Pokemonmove>();

    public virtual ICollection<Pokemonstatpast> Pokemonstatpasts { get; set; } = new List<Pokemonstatpast>();

    public virtual ICollection<Pokemonstat> Pokemonstats { get; set; } = new List<Pokemonstat>();

    public virtual ICollection<Pokemontypepast> Pokemontypepasts { get; set; } = new List<Pokemontypepast>();

    public virtual ICollection<Pokemontype> Pokemontypes { get; set; } = new List<Pokemontype>();
}
