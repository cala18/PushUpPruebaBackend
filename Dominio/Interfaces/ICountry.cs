using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persistencia.Entities;

namespace Dominio.Interfaces
{
    public interface ICountry : IGenericRepository<Country>
    {
        Task GetById();
        Task GetById(int id);
        Task GetByIdAsync(int id);
    }
}