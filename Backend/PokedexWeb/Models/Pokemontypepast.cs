using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class Pokemontypepast
{
    public int Id { get; set; }

    public int Slot { get; set; }

    public int? GenerationId { get; set; }

    public int? PokemonId { get; set; }

    public int? TypeId { get; set; }

    public virtual Generation? Generation { get; set; }

    public virtual Pokemon? Pokemon { get; set; }

    public virtual Type? Type { get; set; }
}
