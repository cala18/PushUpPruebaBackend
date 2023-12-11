using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Interfaces;
using Persistencia.Data;
using Persistencia.Entities;

namespace Aplicacion.Repository
{
    public class PersoRepository : GenericRepository<Person>, IPerson
    {
        private readonly ClayContext _context;
        public PersoRepository(ClayContext context) : base(context)
        {
            _context = context;
        }
    }
}