using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokemonform
{
    public int Id { get; set; }

    public int? Order { get; set; }

    public bool IsDefault { get; set; }

    public bool IsBattleOnly { get; set; }

    public int? VersionGroupId { get; set; }

    public int? PokemonId { get; set; }

    public bool IsMega { get; set; }

    public int? FormOrder { get; set; }

    public string FormName { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual Pokemon? Pokemon { get; set; }

    public virtual ICollection<Pokemonformgeneration> Pokemonformgenerations { get; set; } = new List<Pokemonformgeneration>();

    public virtual ICollection<Pokemonformname> Pokemonformnames { get; set; } = new List<Pokemonformname>();

    public virtual ICollection<Pokemonformtype> Pokemonformtypes { get; set; } = new List<Pokemonformtype>();

    public virtual Versiongroup? VersionGroup { get; set; }
}
