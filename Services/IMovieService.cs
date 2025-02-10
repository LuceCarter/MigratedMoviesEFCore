using System;
using MigratedMoviesEFCore.Models;

namespace MigratedMoviesEFCore.Services;

public interface IMovieService
{
        IEnumerable<Movie> GetAllMovies();

       void AddMovie(Movie movie);
        IEnumerable<Actor> GetAllActors(); 
        
       void AddActor(Actor actor);

        IEnumerable<Theater> GetAllTheaters();

        IEnumerable<User> GetAllUsers();
}
