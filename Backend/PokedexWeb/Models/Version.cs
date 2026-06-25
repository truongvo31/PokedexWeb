using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Version
{
    public int Id { get; set; }

    public int? VersionGroupId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Encounter> Encounters { get; set; } = new List<Encounter>();

    public virtual ICollection<Locationareaencounterrate> Locationareaencounterrates { get; set; } = new List<Locationareaencounterrate>();

    public virtual ICollection<Pokemongameindex> Pokemongameindices { get; set; } = new List<Pokemongameindex>();

    public virtual ICollection<Pokemonitem> Pokemonitems { get; set; } = new List<Pokemonitem>();

    public virtual ICollection<Pokemonspeciesflavortext> Pokemonspeciesflavortexts { get; set; } = new List<Pokemonspeciesflavortext>();

    public virtual Versiongroup? VersionGroup { get; set; }

    public virtual ICollection<Versionname> Versionnames { get; set; } = new List<Versionname>();
}
