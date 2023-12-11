using System;
using System.Collections.Generic;
using Dominio.Entities;

namespace Persistencia.Entities;

public  class Contract : BaseEntity
{
    public int ID { get; set; }

    public int? ClientId { get; set; }

    public DateOnly? ContractDate { get; set; }

    public int? EmployeeId { get; set; }

    public DateOnly? EndDate { get; set; }

    public int? StateId { get; set; }

    public int? ContractTypeId { get; set; }

    public virtual Client? Client { get; set; }

    public virtual Contracttype? ContractType { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();

}
