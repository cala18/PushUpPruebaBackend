using System;
using System.Collections.Generic;

namespace Persistencia.Entities;

public partial class Personcategory
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Person> People { get; set; } = new List<Person>();
}
