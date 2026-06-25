using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Movemetacategory
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Movemetum> Movemeta { get; set; } = new List<Movemetum>();

    public virtual ICollection<Movemetacategorydescription> Movemetacategorydescriptions { get; set; } = new List<Movemetacategorydescription>();
}
