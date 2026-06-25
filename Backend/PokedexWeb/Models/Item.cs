using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Item
{
    public int Id { get; set; }

    public int? Cost { get; set; }

    public int? FlingPower { get; set; }

    public int? ItemCategoryId { get; set; }

    public int? ItemFlingEffectId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Berry> Berries { get; set; } = new List<Berry>();

    public virtual ICollection<Evolutionchain> Evolutionchains { get; set; } = new List<Evolutionchain>();

    public virtual Itemcategory? ItemCategory { get; set; }

    public virtual Itemflingeffect? ItemFlingEffect { get; set; }

    public virtual ICollection<Itemattributemap> Itemattributemaps { get; set; } = new List<Itemattributemap>();

    public virtual ICollection<Itemeffecttext> Itemeffecttexts { get; set; } = new List<Itemeffecttext>();

    public virtual ICollection<Itemflavortext> Itemflavortexts { get; set; } = new List<Itemflavortext>();

    public virtual ICollection<Itemgameindex> Itemgameindices { get; set; } = new List<Itemgameindex>();

    public virtual ICollection<Itemname> Itemnames { get; set; } = new List<Itemname>();

    public virtual ICollection<Machine> Machines { get; set; } = new List<Machine>();

    public virtual ICollection<Pokemonevolution> PokemonevolutionEvolutionItems { get; set; } = new List<Pokemonevolution>();

    public virtual ICollection<Pokemonevolution> PokemonevolutionHeldItems { get; set; } = new List<Pokemonevolution>();

    public virtual ICollection<Pokemonitem> Pokemonitems { get; set; } = new List<Pokemonitem>();
}
