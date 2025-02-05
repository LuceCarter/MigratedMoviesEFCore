using System;
using MigratedMoviesEFCore.Models;

namespace MigratedMoviesEFCore.Services;

public interface IMovieService
{
        IEnumerable<Movie> GetAllMovies();

       void AddMovie(Movie movie);
        IEnumerable<Actor> GetAllActors(); 
        
       void AddActor(Actor actor);
        IEnumerable<Comment> GetAllComments();
        IEnumerable<MovieCast> GetAllMovieCasts();
        IEnumerable<MovieGenres> GetAllMovieGenres();

        IEnumerable<Theater> GetAllTheaters();

        IEnumerable<User> GetAllUsers();
}
