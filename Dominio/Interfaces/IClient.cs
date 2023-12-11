using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persistencia.Entities;

namespace Dominio.Interfaces
{
    public interface IClient : IGenericRepository<Client>
    {
        Task GetByIdAsync();
    }
}