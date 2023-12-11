using System;
using System.Collections.Generic;

namespace Persistencia.Entities;

public partial class Shift
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public TimeOnly? StartTime { get; set; }

    public TimeOnly? EndTime { get; set; }

    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
}
