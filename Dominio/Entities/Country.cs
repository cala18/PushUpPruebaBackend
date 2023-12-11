﻿using System;
using System.Collections.Generic;

namespace Persistencia.Entities;

public partial class Country
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();
}
