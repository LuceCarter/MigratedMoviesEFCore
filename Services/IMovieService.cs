using System;
using MigratedMoviesEFCore.Models;

namespace MigratedMoviesEFCore.Services;

public interface IMovieService
{
        IEnumerable<Movie> GetAllMovies();
        IEnumerable<Actor> GetAllActors();       
        IEnumerable<Comment> GetAllComments();
        IEnumerable<MovieCast> GetAllMovieCasts();
        IEnumerable<MovieGenres> GetAllMovieGenres();

        IEnumerable<Theater> GetAllTheaters();

        IEnumerable<User> GetAllUsers();
}
