using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Language
{
    public int Id { get; set; }

    public string Iso639 { get; set; } = null!;

    public string Iso3166 { get; set; } = null!;

    public bool Official { get; set; }

    public int? Order { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Abilitychangeeffecttext> Abilitychangeeffecttexts { get; set; } = new List<Abilitychangeeffecttext>();

    public virtual ICollection<Abilityeffecttext> Abilityeffecttexts { get; set; } = new List<Abilityeffecttext>();

    public virtual ICollection<Abilityflavortext> Abilityflavortexts { get; set; } = new List<Abilityflavortext>();

    public virtual ICollection<Abilityname> Abilitynames { get; set; } = new List<Abilityname>();

    public virtual ICollection<Berryfirmnessname> Berryfirmnessnames { get; set; } = new List<Berryfirmnessname>();

    public virtual ICollection<Berryflavorname> Berryflavornames { get; set; } = new List<Berryflavorname>();

    public virtual ICollection<Characteristicdescription> Characteristicdescriptions { get; set; } = new List<Characteristicdescription>();

    public virtual ICollection<Contesteffecteffecttext> Contesteffecteffecttexts { get; set; } = new List<Contesteffecteffecttext>();

    public virtual ICollection<Contesteffectflavortext> Contesteffectflavortexts { get; set; } = new List<Contesteffectflavortext>();

    public virtual ICollection<Contesttypename> Contesttypenames { get; set; } = new List<Contesttypename>();

    public virtual ICollection<Egggroupname> Egggroupnames { get; set; } = new List<Egggroupname>();

    public virtual ICollection<Encounterconditionname> Encounterconditionnames { get; set; } = new List<Encounterconditionname>();

    public virtual ICollection<Encounterconditionvaluename> Encounterconditionvaluenames { get; set; } = new List<Encounterconditionvaluename>();

    public virtual ICollection<Encountermethodname> Encountermethodnames { get; set; } = new List<Encountermethodname>();

    public virtual ICollection<Evolutiontriggername> Evolutiontriggernames { get; set; } = new List<Evolutiontriggername>();

    public virtual ICollection<Generationname> Generationnames { get; set; } = new List<Generationname>();

    public virtual ICollection<Growthratedescription> Growthratedescriptions { get; set; } = new List<Growthratedescription>();

    public virtual ICollection<Itemattributedescription> Itemattributedescriptions { get; set; } = new List<Itemattributedescription>();

    public virtual ICollection<Itemattributename> Itemattributenames { get; set; } = new List<Itemattributename>();

    public virtual ICollection<Itemcategoryname> Itemcategorynames { get; set; } = new List<Itemcategoryname>();

    public virtual ICollection<Itemeffecttext> Itemeffecttexts { get; set; } = new List<Itemeffecttext>();

    public virtual ICollection<Itemflavortext> Itemflavortexts { get; set; } = new List<Itemflavortext>();

    public virtual ICollection<Itemflingeffecteffecttext> Itemflingeffecteffecttexts { get; set; } = new List<Itemflingeffecteffecttext>();

    public virtual ICollection<Itemname> Itemnames { get; set; } = new List<Itemname>();

    public virtual ICollection<Itempocketname> Itempocketnames { get; set; } = new List<Itempocketname>();

    public virtual ICollection<Languagename> LanguagenameLanguages { get; set; } = new List<Languagename>();

    public virtual ICollection<Languagename> LanguagenameLocalLanguages { get; set; } = new List<Languagename>();

    public virtual ICollection<Locationareaname> Locationareanames { get; set; } = new List<Locationareaname>();

    public virtual ICollection<Locationname> Locationnames { get; set; } = new List<Locationname>();

    public virtual ICollection<Moveattributedescription> Moveattributedescriptions { get; set; } = new List<Moveattributedescription>();

    public virtual ICollection<Moveattributename> Moveattributenames { get; set; } = new List<Moveattributename>();

    public virtual ICollection<Movebattlestylename> Movebattlestylenames { get; set; } = new List<Movebattlestylename>();

    public virtual ICollection<Movedamageclassdescription> Movedamageclassdescriptions { get; set; } = new List<Movedamageclassdescription>();

    public virtual ICollection<Movedamageclassname> Movedamageclassnames { get; set; } = new List<Movedamageclassname>();

    public virtual ICollection<Moveeffectchangeeffecttext> Moveeffectchangeeffecttexts { get; set; } = new List<Moveeffectchangeeffecttext>();

    public virtual ICollection<Moveeffecteffecttext> Moveeffecteffecttexts { get; set; } = new List<Moveeffecteffecttext>();

    public virtual ICollection<Moveflavortext> Moveflavortexts { get; set; } = new List<Moveflavortext>();

    public virtual ICollection<Movelearnmethoddescription> Movelearnmethoddescriptions { get; set; } = new List<Movelearnmethoddescription>();

    public virtual ICollection<Movelearnmethodname> Movelearnmethodnames { get; set; } = new List<Movelearnmethodname>();

    public virtual ICollection<Movemetaailmentname> Movemetaailmentnames { get; set; } = new List<Movemetaailmentname>();

    public virtual ICollection<Movemetacategorydescription> Movemetacategorydescriptions { get; set; } = new List<Movemetacategorydescription>();

    public virtual ICollection<Movename> Movenames { get; set; } = new List<Movename>();

    public virtual ICollection<Movetargetdescription> Movetargetdescriptions { get; set; } = new List<Movetargetdescription>();

    public virtual ICollection<Movetargetname> Movetargetnames { get; set; } = new List<Movetargetname>();

    public virtual ICollection<Naturename> Naturenames { get; set; } = new List<Naturename>();

    public virtual ICollection<Palparkareaname> Palparkareanames { get; set; } = new List<Palparkareaname>();

    public virtual ICollection<Pokeathlonstatname> Pokeathlonstatnames { get; set; } = new List<Pokeathlonstatname>();

    public virtual ICollection<Pokedexdescription> Pokedexdescriptions { get; set; } = new List<Pokedexdescription>();

    public virtual ICollection<Pokedexname> Pokedexnames { get; set; } = new List<Pokedexname>();

    public virtual ICollection<Pokemoncolorname> Pokemoncolornames { get; set; } = new List<Pokemoncolorname>();

    public virtual ICollection<Pokemonformname> Pokemonformnames { get; set; } = new List<Pokemonformname>();

    public virtual ICollection<Pokemonhabitatname> Pokemonhabitatnames { get; set; } = new List<Pokemonhabitatname>();

    public virtual ICollection<Pokemonshapename> Pokemonshapenames { get; set; } = new List<Pokemonshapename>();

    public virtual ICollection<Pokemonspeciesdescription> Pokemonspeciesdescriptions { get; set; } = new List<Pokemonspeciesdescription>();

    public virtual ICollection<Pokemonspeciesflavortext> Pokemonspeciesflavortexts { get; set; } = new List<Pokemonspeciesflavortext>();

    public virtual ICollection<Pokemonspeciesname> Pokemonspeciesnames { get; set; } = new List<Pokemonspeciesname>();

    public virtual ICollection<Regionname> Regionnames { get; set; } = new List<Regionname>();

    public virtual ICollection<Statname> Statnames { get; set; } = new List<Statname>();

    public virtual ICollection<Supercontesteffectflavortext> Supercontesteffectflavortexts { get; set; } = new List<Supercontesteffectflavortext>();

    public virtual ICollection<Typename> Typenames { get; set; } = new List<Typename>();

    public virtual ICollection<Versionname> Versionnames { get; set; } = new List<Versionname>();
}
