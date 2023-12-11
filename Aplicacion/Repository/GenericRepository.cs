using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia.Data;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace Aplicacion.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly ClayContext _context;
        public GenericRepository(ClayContext context)
        {
            _context = context;
        }

        void IGenericRepository<T>.Add(T entity)
        {
           _context.Set<T>().Add(entity);
        }

        void IGenericRepository<T>.AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        IEnumerable<T> IGenericRepository<T>.Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }

        async Task<IEnumerable<T>> IGenericRepository<T>.GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        async Task<T> IGenericRepository<T>.GetByIdAsync(string id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        void IGenericRepository<T>.Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        void IGenericRepository<T>.RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }

        void IGenericRepository<T>.Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}