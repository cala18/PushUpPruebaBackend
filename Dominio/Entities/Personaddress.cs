using System;
using System.Collections.Generic;
using Dominio.Entities;

namespace Persistencia.Entities;

public partial class Personaddress : BaseEntity
{
    public int Id { get; set; }

    public string? Address { get; set; }

    public int? PersonId { get; set; }

    public int? AddressTypeId { get; set; }

    public virtual Addresstype? AddressType { get; set; }

    public virtual Person? Person { get; set; }
}
