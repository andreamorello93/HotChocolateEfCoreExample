using HotChocolate;
using HotChocolate.Types;
using HotChocolateEfCoreExample.Application.Interfaces;

namespace HotChocolateEfCoreExample.Application.GraphQL.Resolvers
{
    public class BaseResolver<TModel, TKey> where TModel : class
    {
        [UsePaging]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public virtual IQueryable<TModel> Get([Service] IGenericRepository<TModel, TKey> repository) => repository.Queryable();
    }
}
