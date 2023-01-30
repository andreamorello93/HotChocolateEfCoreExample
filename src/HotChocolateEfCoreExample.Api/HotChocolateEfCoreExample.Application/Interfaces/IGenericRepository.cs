using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotChocolateEfCoreExample.Application.Interfaces
{
    public interface IGenericRepository<TModel, TKey> where TModel : class
    {
        TModel GetById(TKey id);
        IEnumerable<TModel> GetAll();
        IQueryable<TModel> Queryable();
        IEnumerable<TModel> Find(Expression<Func<TModel, bool>> expression);
        void Add(TModel entity);
        void AddRange(IEnumerable<TModel> entities);
        void Remove(TModel entity);
        void RemoveRange(IEnumerable<TModel> entities);
    }
}
