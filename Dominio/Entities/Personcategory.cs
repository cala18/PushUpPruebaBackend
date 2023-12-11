using System;
using System.Collections.Generic;
using Dominio.Entities;

namespace Persistencia.Entities;

public partial class Personcategory : BaseEntity
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Person> People { get; set; } = new List<Person>();
}
