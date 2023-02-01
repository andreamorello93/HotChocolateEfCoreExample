using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.Types;
using HotChocolateEfCoreExample.Application.Interfaces;
using HotChocolateEfCoreExample.DAL.Models;

namespace HotChocolateEfCoreExample.Application.GraphQL.Mutations
{
    [ExtendObjectType("Mutation")]
    public class CustomerMutation : BaseMutation<Customer, int>
    {
        [GraphQLName("CustomerInsert")]
        public override Task<Customer> Insert(Customer entity, [Service] IGenericRepository<Customer, int> repository) => base.Insert(entity, repository);
        [GraphQLName("CustomerUpdate")]
        public override Task<Customer> Update(Customer entity, [Service] IGenericRepository<Customer, int> repository) => base.Update(entity, repository);
        [GraphQLName("CustomerDelete")]
        public override Task<bool> Delete(int id, [Service] IGenericRepository<Customer, int> repository) => base.Delete(id, repository);
    }
}
