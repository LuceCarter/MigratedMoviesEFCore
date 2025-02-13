using Microsoft.EntityFrameworkCore;
using MigratedMoviesEFCore.Models;
using MigratedMoviesEFCore.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddOpenApi();

builder.Services.AddDbContext<MoviesDbContext>(options =>
    options.UseMongoDB(builder.Configuration.GetConnectionString("MongoDBAtlasConnectionString"), "migrated_mflix")
           .EnableSensitiveDataLogging());

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

#region movies
app.MapGet("/movies", (IMovieService movieService) =>
{
    return movieService.GetAllMovies();
})
.WithName("GetMovies");

app.MapGet("/movies/{id}", (IMovieService movieService, string id) =>
{
    return movieService.GetMovieById(id);
}).WithName("GetMovieById");

app.MapPost("/movies", (IMovieService movieService, Movie movie) =>
{
    string newId = movieService.AddMovie(movie);
    return newId;
}).WithName("AddMovie");

app.MapPut("/movies/{id}", (IMovieService movieService, string id, Movie movieToUpdate) =>
{
    movieService.UpdateMovie(id, movieToUpdate);
}).WithName("UpdateMovie");

app.MapDelete("/movies/{id}", (IMovieService movieService, string id) =>
{
    var movieToDelete = movieService.GetMovieById(id);
    movieService.DeleteMovie(movieToDelete);
}).WithName("DeleteMovie");
#endregion

#region actors
app.MapGet("/actors", (IMovieService movieService) =>
{
    return movieService.GetAllActors();
}).WithName("GetActors");

app.MapGet("/actors/{id}", (IMovieService movieService, string id) =>
{
    return movieService.GetActorById(id);
}).WithName("GetActorById");

app.MapPost("/actors", (IMovieService movieService, Actor actor) =>
{
    string newId = movieService.AddActor(actor);
    return newId;
}).WithName("AddActor");

app.MapPut("/actors/{id}", (IMovieService movieService, string id, Actor actorToUpdate) =>
{
    movieService.UpdateActor(id, actorToUpdate);
}).WithName("UpdateActor");

app.MapDelete("/actors/{id}", (IMovieService movieService, string id) =>
{
    var actorToDelete = movieService.GetActorById(id);
    movieService.DeleteActor(actorToDelete);
}).WithName("DeleteActor");
#endregion

app.MapGet("/theaters", (IMovieService movieService) =>
{
    return movieService.GetAllTheaters();
}).WithName("GetTheaters");

app.MapGet("/users", (IMovieService movieService) =>
{
    return movieService.GetAllUsers();
}).WithName("GetUsers");

app.Run();