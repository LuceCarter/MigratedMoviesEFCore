using Microsoft.EntityFrameworkCore;
using MigratedMoviesEFCore.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<MoviesDbContext>(options =>
options.UseNpgsql(builder.Configuration.GetConnectionString("MoviesContext")));

builder.Services.AddScoped<IMovieService, MovieService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/movies", (IMovieService movieService) =>
{
   return movieService.GetAllMovies();
})
.WithName("GetMovies");

app.Run();

