using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokemonspecy
{
    public int Id { get; set; }

    public int? Order { get; set; }

    public int? GenderRate { get; set; }

    public int? CaptureRate { get; set; }

    public int? BaseHappiness { get; set; }

    public bool IsBaby { get; set; }

    public int? HatchCounter { get; set; }

    public bool HasGenderDifferences { get; set; }

    public bool FormsSwitchable { get; set; }

    public int? EvolutionChainId { get; set; }

    public int? GenerationId { get; set; }

    public int? GrowthRateId { get; set; }

    public int? PokemonColorId { get; set; }

    public int? PokemonHabitatId { get; set; }

    public int? PokemonShapeId { get; set; }

    public bool IsLegendary { get; set; }

    public bool IsMythical { get; set; }

    public string Name { get; set; } = null!;

    public int? EvolvesFromSpeciesId { get; set; }

    public virtual Evolutionchain? EvolutionChain { get; set; }

    public virtual Pokemonspecy? EvolvesFromSpecies { get; set; }

    public virtual Generation? Generation { get; set; }

    public virtual Growthrate? GrowthRate { get; set; }

    public virtual ICollection<Pokemonspecy> InverseEvolvesFromSpecies { get; set; } = new List<Pokemonspecy>();

    public virtual ICollection<Palpark> Palparks { get; set; } = new List<Palpark>();

    public virtual Pokemoncolor? PokemonColor { get; set; }

    public virtual Pokemonhabitat? PokemonHabitat { get; set; }

    public virtual Pokemonshape? PokemonShape { get; set; }

    public virtual ICollection<Pokemondexnumber> Pokemondexnumbers { get; set; } = new List<Pokemondexnumber>();

    public virtual ICollection<Pokemonegggroup> Pokemonegggroups { get; set; } = new List<Pokemonegggroup>();

    public virtual ICollection<Pokemonevolution> PokemonevolutionEvolvedSpecies { get; set; } = new List<Pokemonevolution>();

    public virtual ICollection<Pokemonevolution> PokemonevolutionPartySpecies { get; set; } = new List<Pokemonevolution>();

    public virtual ICollection<Pokemonevolution> PokemonevolutionTradeSpecies { get; set; } = new List<Pokemonevolution>();

    public virtual ICollection<Pokemon> Pokemons { get; set; } = new List<Pokemon>();

    public virtual ICollection<Pokemonspeciesdescription> Pokemonspeciesdescriptions { get; set; } = new List<Pokemonspeciesdescription>();

    public virtual ICollection<Pokemonspeciesflavortext> Pokemonspeciesflavortexts { get; set; } = new List<Pokemonspeciesflavortext>();

    public virtual ICollection<Pokemonspeciesname> Pokemonspeciesnames { get; set; } = new List<Pokemonspeciesname>();
}
