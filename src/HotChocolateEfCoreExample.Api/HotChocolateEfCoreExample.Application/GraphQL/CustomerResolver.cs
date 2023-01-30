using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.Configuration.Validation;
using HotChocolate.Types;
using HotChocolateEfCoreExample.Application.Interfaces;
using HotChocolateEfCoreExample.DAL.Models;

namespace HotChocolateEfCoreExample.Application.GraphQL
{
    [ExtendObjectType("Query")]
    public class CustomerResolver : BaseResolver<Customer, int>
    {
        [GraphQLName("Customers")]
        public override IQueryable<Customer> Get(IGenericRepository<Customer, int> repository) => base.Get(repository);
    }
}
