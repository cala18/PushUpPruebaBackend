using System;
using System.Collections.Generic;
using Dominio.Entities;

namespace Persistencia.Entities;

public partial class Department : BaseEntity
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? CountryId { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();

    public virtual Country? Country { get; set; }
}
