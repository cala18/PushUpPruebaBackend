using System;
using System.Collections.Generic;
using Dominio.Entities;

namespace Persistencia.Entities;

public partial class Schedule : BaseEntity
{
    public int Id { get; set; }

    public int? ContractId { get; set; }

    public int? ShiftId { get; set; }

    public int? EmployeeId { get; set; }

    public virtual Contract? Contract { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual Shift? Shift { get; set; }
}
