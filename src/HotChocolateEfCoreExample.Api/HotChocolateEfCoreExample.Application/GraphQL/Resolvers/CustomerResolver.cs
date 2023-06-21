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
        public override IQueryable<Customer> GetUsingPaging(IGenericRepository<Customer, int> repository) => base.GetUsingPaging(repository);

        [GraphQLName("CustomersOffsetPaging")]
        public override IQueryable<Customer> GetUsingOffsetPaging(IGenericRepository<Customer, int> repository) => base.GetUsingOffsetPaging(repository);
    }

    public class CustomerType : ObjectType<Customer>
    {
        protected override void Configure(IObjectTypeDescriptor<Customer> descriptor)
        {
            descriptor.Field(f => f.SalesOrderHeader).UseFiltering();
        }
    }

}
