using Microsoft.EntityFrameworkCore;
using MigratedMoviesEFCore.Models;
using MigratedMoviesEFCore.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<MoviesDbContext>(options =>
options.UseNpgsql(builder.Configuration.GetConnectionString("MoviesContext")));

builder.Services.AddScoped<IMovieService, MovieService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();

app.MapGet("/movies", (IMovieService movieService) =>
{
   return movieService.GetAllMovies();
})
.WithName("GetMovies");

app.MapGet("/actors", (IMovieService movieService) =>
{
   return movieService.GetAllActors();
}).WithName("GetActors");

app.MapGet("/comments", (IMovieService movieService) =>
{
   return movieService.GetAllComments();
}).WithName("GetComments");

app.MapGet("/moviecasts", (IMovieService movieService) =>
{
   return movieService.GetAllMovieCasts();
}).WithName("GetMovieCasts");

app.MapGet("/moviegenres", (IMovieService movieService) =>
{
   return movieService.GetAllMovieGenres();
}).WithName("GetMovieGenres");

app.MapGet("/theaters", (IMovieService movieService) =>
{
   return movieService.GetAllTheaters();
}).WithName("GetTheaters");

app.MapGet("/users", (IMovieService movieService) =>
{
   return movieService.GetAllUsers();
}).WithName("GetUsers");

app.MapPost("/movies", (IMovieService movieService, Movie movie) =>
{
  movieService.AddMovie(movie);
}).WithName("AddMovie");

app.MapPost("/actors", (IMovieService movieService, Actor actor) =>
{
  movieService.AddActor(actor);
}).WithName("AddActor");

app.Run();

