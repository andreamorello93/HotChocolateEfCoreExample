using HotChocolate.Execution.Configuration;
using HotChocolateEfCoreExample.Application.GraphQL.Mutations;
using HotChocolateEfCoreExample.Application.GraphQL.Resolvers;

namespace HotChocolateEfCoreExample.Api.Extensions
{
    public static class RequestExecutorBuilderExtensions
    {
        public static IRequestExecutorBuilder AddResolvers(this IRequestExecutorBuilder requestExecutionBuilder)
        {
            return requestExecutionBuilder
                    .AddType<CustomerResolver>()
                    .AddType<CustomerType>()
                ;
        }

        public static IRequestExecutorBuilder AddMutations(this IRequestExecutorBuilder requestExecutionBuilder)
        {
            return requestExecutionBuilder
                    .AddType<CustomerMutation>()
                ;
        }
    }
}
