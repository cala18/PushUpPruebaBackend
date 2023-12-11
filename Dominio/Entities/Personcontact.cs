using System;
using System.Collections.Generic;
using Dominio.Entities;

namespace Persistencia.Entities;

public partial class Personcontact : BaseEntity
{
    public int Id { get; set; }

    public int? PersonId { get; set; }

    public int? ContactTypeId { get; set; }

    public virtual Contacttype? ContactType { get; set; }

    public virtual Person? Person { get; set; }
}
