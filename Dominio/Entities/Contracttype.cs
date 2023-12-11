using System;
using System.Collections.Generic;

namespace Persistencia.Entities;

public partial class Contracttype
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();
}
