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
        public virtual IQueryable<TModel> GetUsingPaging([Service] IGenericRepository<TModel, TKey> repository) => repository.Queryable();

        [UseOffsetPaging]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public virtual IQueryable<TModel> GetUsingOffsetPaging([Service] IGenericRepository<TModel, TKey> repository) => repository.Queryable();
    }
}
