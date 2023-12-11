using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Interfaces;
using Persistencia.Data;
using Persistencia.Entities;

namespace Aplicacion.Repository
{
    public class EmployeeRespository : GenericRepository<Employee>, IEmployee
    {
              private readonly ClayContext _context;
        public EmployeeRespository(ClayContext context) : base(context)
        {
            _context = context;
        }
    }
}