using HotChocolateEfCoreExample.Application.GraphQL;
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
    .AddProjections()
    .AddFiltering()
    .AddSorting()
    .RegisterDbContext<AdventureWorks2019Context>()
    .AddQueryType(d => d.Name("Query"))
    .AddType<CustomerResolver>()
    ;

builder.Services.AddTransient<IGenericRepository<Customer, int>, CustomerRepository>();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGraphQL();

app.Run();
