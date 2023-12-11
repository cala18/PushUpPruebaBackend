using System;
using System.Collections.Generic;
using Dominio.Entities;

namespace Persistencia.Entities;

public partial class City : BaseEntity
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int? DepartmentId { get; set; }

    public virtual Department Department { get; set; }

    public virtual ICollection<Person> People { get; set; } = new List<Person>();
}
