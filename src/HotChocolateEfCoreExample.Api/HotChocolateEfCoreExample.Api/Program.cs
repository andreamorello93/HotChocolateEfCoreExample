using HotChocolate.Types.Pagination;
using HotChocolateEfCoreExample.Api.Extensions;
using HotChocolateEfCoreExample.Application.GraphQL;
using HotChocolateEfCoreExample.Application.GraphQL.Mutations;
using HotChocolateEfCoreExample.Application.GraphQL.Resolvers;
using HotChocolateEfCoreExample.Application.Interfaces;
using HotChocolateEfCoreExample.Application.Repositories;
using HotChocolateEfCoreExample.DAL.Data;
using HotChocolateEfCoreExample.DAL.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AdventureWorks2019Context>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services
    .AddGraphQLServer()
    .UseDefaultPipeline()
    .AddErrorFilter<GraphQLErrorFilter>()
    .AddProjections()
    .AddFiltering()
    .AddSorting()
    .RegisterDbContext<AdventureWorks2019Context>(DbContextKind.Pooled)
    .AddQueryType(d => d.Name("Query"))
    .AddResolvers()
    .AddMutationType(d => d.Name("Mutation"))
    .AddMutations()
    .SetPagingOptions(new PagingOptions { DefaultPageSize = 500, MaxPageSize = 500 })
    ;

builder.Services.AddTransient<IGenericRepository<Customer, int>, CustomerRepository>();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGraphQL();

app.Run();
