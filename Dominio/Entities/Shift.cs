using System;
using System.Collections.Generic;
using Dominio.Entities;

namespace Persistencia.Entities;

public partial class Shift : BaseEntity
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public TimeOnly? StartTime { get; set; }

    public TimeOnly? EndTime { get; set; }

    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
}
