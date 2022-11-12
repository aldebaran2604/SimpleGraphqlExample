using GraphQL;
using GraphQL.Server.Ui.GraphiQL;
using GraphQL.Types;
using GraphqlProject.Data;
using GraphqlProject.Interfaces;
using GraphqlProject.Mutation;
using GraphqlProject.Query;
using GraphqlProject.Schema;
using GraphqlProject.Services;
using GraphqlProject.Type;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration;

builder.Services.AddTransient<IMenu, MenuService>();
builder.Services.AddTransient<ISubMenu, SubMenuService>();
builder.Services.AddTransient<IReservation, ReservationService>();
builder.Services.AddTransient<MenuType>();
builder.Services.AddTransient<SubMenuType>();
builder.Services.AddTransient<ReservationType>();
builder.Services.AddTransient<MenuQuery>();
builder.Services.AddTransient<SubMenuQuery>();
builder.Services.AddTransient<ReservationQuery>();
builder.Services.AddTransient<RootQuery>();
builder.Services.AddTransient<MenuMutation>();
builder.Services.AddTransient<SubMenuMutation>();
builder.Services.AddTransient<ReservationMutation>();
builder.Services.AddTransient<RootMutation>();
builder.Services.AddTransient<MenuInputType>();
builder.Services.AddTransient<SubMenuInputType>();
builder.Services.AddTransient<ReservationInputType>();
builder.Services.AddTransient<ISchema, RootSchema>();

builder.Services.AddGraphQL(configure =>
{
    configure.ConfigureExecutionOptions(options =>
    {
        options.EnableMetrics = false;
    });

    configure.AddGraphTypes();
    configure.AddDataLoader();
    configure.AddSystemTextJson();
});

builder.Services.AddDbContext<GraphQLDbContext>(options =>
{
    options.UseSqlite(configuration.GetConnectionString("DBConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapGraphQL<RootSchema>();

app.Run();