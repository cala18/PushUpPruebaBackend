using System;
using System.Collections.Generic;

namespace Persistencia.Entities;

public partial class Client
{
    public int ClientId { get; set; }

    public int? PersonId { get; set; }

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual Person? Person { get; set; }
}
