using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Interfaces;
using Persistencia.Data;
using Persistencia.Entities;

namespace Aplicacion.Repository
{
    public class ClientRepository : GenericRepository<Client>, IClient
    {
              private readonly ClayContext _context;
        public ClientRepository(ClayContext context) : base(context)
        {
            _context = context;
        }
    }
}