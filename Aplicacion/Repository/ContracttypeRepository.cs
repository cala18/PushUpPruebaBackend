using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Interfaces;
using Persistencia.Data;
using Persistencia.Entities;

namespace Aplicacion.Repository
{
    public class ContracttypeRepository : GenericRepository<Contracttype>, IContracttype
    {
              private readonly ClayContext _context;
        public ContracttypeRepository(ClayContext context) : base(context)
        {
            _context = context;
        }
    }
}