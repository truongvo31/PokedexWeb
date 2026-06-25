using System;
using System.Collections.Generic;

namespace PokedexWeb.Models;

public partial class AuthPermission
{
    public int Id { get; set; }

    public int ContentTypeId { get; set; }

    public string Codename { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<AuthGroupPermission> AuthGroupPermissions { get; set; } = new List<AuthGroupPermission>();

    public virtual ICollection<AuthUserUserPermission> AuthUserUserPermissions { get; set; } = new List<AuthUserUserPermission>();
}
