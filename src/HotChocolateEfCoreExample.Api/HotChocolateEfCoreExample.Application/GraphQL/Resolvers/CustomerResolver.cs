using HotChocolate;
using HotChocolate.Types;
using HotChocolateEfCoreExample.Application.Interfaces;
using HotChocolateEfCoreExample.DAL.Models;

namespace HotChocolateEfCoreExample.Application.GraphQL.Resolvers
{
    [ExtendObjectType("Query")]
    public class CustomerResolver : BaseResolver<Customer, int>
    {
        [GraphQLName("Customers")]
        public override IQueryable<Customer> Get(IGenericRepository<Customer, int> repository) => base.Get(repository);
    }
}
