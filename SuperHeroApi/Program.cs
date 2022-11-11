using Microsoft.EntityFrameworkCore;
using SuperHeroApi.Data;
using SuperHeroApi.Interfaces;
using SuperHeroApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration;

// Register custom services for the superheroes
builder.Services.AddScoped<ISuperheroRepository, SuperheroRepository>();
builder.Services.AddScoped<ISuperpowerRepository, SuperpowerRepository>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddGraphQLServer().AddQueryType<Query>().AddProjections().AddFiltering().AddSorting();

// Add Application Db Context options
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlite(configuration.GetConnectionString("SqlServer"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}

app.MapGraphQL();

app.Run();