using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Characteristicdescription
{
    public int Id { get; set; }

    public int? CharacteristicId { get; set; }

    public int? LanguageId { get; set; }

    public string Description { get; set; } = null!;

    public virtual Characteristic? Characteristic { get; set; }

    public virtual Language? Language { get; set; }
}
