using System;
using MigratedMoviesEFCore.Models;

namespace MigratedMoviesEFCore.Services;

public interface IMovieService
{
    IEnumerable<Movie> GetAllMovies();
        
    Movie GetMovieById(string id);
        
    void UpdateMovie(Movie movie);

    void DeleteMovie(Movie movieToDelete);

    string AddMovie(Movie movie);
    IEnumerable<Actor> GetAllActors(); 
        
    Actor GetActorById(string id);
        
    void UpdateActor(Actor actor);

    void DeleteActor(Actor actorToDelete);
        
    string AddActor(Actor actor);

    IEnumerable<Theater> GetAllTheaters();

    IEnumerable<User> GetAllUsers();
}
