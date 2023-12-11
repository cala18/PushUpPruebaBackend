using System;
using System.Collections.Generic;
using Dominio.Entities;

namespace Persistencia.Entities;

public partial class Contacttype : BaseEntity
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Personcontact> Personcontacts { get; set; } = new List<Personcontact>();
}
