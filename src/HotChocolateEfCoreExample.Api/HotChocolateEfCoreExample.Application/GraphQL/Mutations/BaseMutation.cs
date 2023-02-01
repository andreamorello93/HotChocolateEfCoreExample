using HotChocolate.Types;
using HotChocolate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotChocolateEfCoreExample.Application.Interfaces;

namespace HotChocolateEfCoreExample.Application.GraphQL.Mutations
{
    public class BaseMutation<TModel, TKey> where TModel : class, new()
    {
        public virtual Task<TModel> Insert(TModel entity, IGenericRepository<TModel, TKey> repository) => repository.Insert(entity);

        public virtual Task<TModel> Update(TModel entity, TKey id, IGenericRepository<TModel, TKey> repository) => repository.Update(entity, id);

        public virtual Task<bool> Delete(TKey id, IGenericRepository<TModel, TKey> repository) => repository.Delete(id);
    }
}
