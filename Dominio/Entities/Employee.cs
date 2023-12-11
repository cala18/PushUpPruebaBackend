using System;
using System.Collections.Generic;

namespace Persistencia.Entities;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public int? PersonId { get; set; }

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual Person? Person { get; set; }

    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
}
