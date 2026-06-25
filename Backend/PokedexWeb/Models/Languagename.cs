using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Languagename
{
    public int Id { get; set; }

    public int? LanguageId { get; set; }

    public int? LocalLanguageId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Language? Language { get; set; }

    public virtual Language? LocalLanguage { get; set; }
}
