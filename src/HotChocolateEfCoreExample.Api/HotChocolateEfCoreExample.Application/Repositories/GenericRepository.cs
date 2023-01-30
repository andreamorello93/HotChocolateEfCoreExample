using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using HotChocolateEfCoreExample.Application.Interfaces;
using HotChocolateEfCoreExample.DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace HotChocolateEfCoreExample.Application.Repositories
{
    public class GenericRepository<TModel, TKey> : IGenericRepository<TModel, TKey> where TModel : class
    {
        private readonly AdventureWorks2019Context _context;
        private readonly DbSet<TModel> _dbSet;

        public GenericRepository(AdventureWorks2019Context context)
        {
            _context = context;
            _dbSet = _context.Set<TModel>();
        }
        public void Add(TModel entity)
        {
            _dbSet.Add(entity);
        }
        public void AddRange(IEnumerable<TModel> entities)
        {
            _dbSet.AddRange(entities);
        }

        public IQueryable<TModel> Queryable()
        {
           return _dbSet;
        }

        public IEnumerable<TModel> Find(Expression<Func<TModel, bool>> expression)
        {
            return _dbSet.Where(expression);
        }
        public IEnumerable<TModel> GetAll()
        {
            return _dbSet.ToList();
        }
        public TModel GetById(TKey id)
        {
            return _dbSet.Find(id);
        }
        public void Remove(TModel entity)
        {
            _dbSet.Remove(entity);
        }
        public void RemoveRange(IEnumerable<TModel> entities)
        {
            _dbSet.RemoveRange(entities);
        }
    }
}
