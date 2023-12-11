﻿using System;
using System.Collections.Generic;
using Dominio.Entities;

namespace Persistencia.Entities;

public partial class Person : BaseEntity
{
    public int Id { get; set; }

    public string? PersonId { get; set; }

    public string? Name { get; set; }

    public DateOnly? RegistrationDate { get; set; }

    public int? PersonTypeId { get; set; }

    public int? PersonCategoryId { get; set; }

    public int? CityId { get; set; }

    public virtual City? City { get; set; }

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual Personcategory? PersonCategory { get; set; }

    public virtual Persontype? PersonType { get; set; }

    public virtual ICollection<Personaddress> Personaddresses { get; set; } = new List<Personaddress>();

    public virtual ICollection<Personcontact> Personcontacts { get; set; } = new List<Personcontact>();
}
