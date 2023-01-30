using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotChocolateEfCoreExample.DAL.Data;
using HotChocolateEfCoreExample.DAL.Models;

namespace HotChocolateEfCoreExample.Application.Repositories
{
    public class CustomerRepository : GenericRepository<Customer, int>
    {
        public CustomerRepository(AdventureWorks2019Context context) : base(context)
        {
        }
    }
}
