using System;
using System.Collections.Generic;
using Dominio.Entities;

namespace Persistencia.Entities;

public partial class Contracttype : BaseEntity
{
        public int ID { get; set; }

        public string Description { get; set; }

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();
}
