using System;
using System.Collections.Generic;
using Dominio.Entities;

namespace Persistencia.Entities;

public partial class Addresstype : BaseEntity
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Personaddress> Personaddresses { get; set; } = new List<Personaddress>();
}
