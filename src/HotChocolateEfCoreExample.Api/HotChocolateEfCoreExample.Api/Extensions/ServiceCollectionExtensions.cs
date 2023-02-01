using HotChocolateEfCoreExample.Application.Interfaces;
using HotChocolateEfCoreExample.Application.Repositories;
using HotChocolateEfCoreExample.DAL.Models;

namespace HotChocolateEfCoreExample.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddTransient<IGenericRepository<Customer, int>, CustomerRepository>()
                ;
        }
    }
}
