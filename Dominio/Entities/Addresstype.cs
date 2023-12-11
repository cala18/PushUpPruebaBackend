using System;
using System.Collections.Generic;

namespace Persistencia.Entities;

public partial class Addresstype
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Personaddress> Personaddresses { get; set; } = new List<Personaddress>();
}
