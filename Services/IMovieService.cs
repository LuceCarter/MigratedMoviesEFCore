using System;
using MigratedMoviesEFCore.Models;

namespace MigratedMoviesEFCore.Services;

public interface IMovieService
{
        IEnumerable<Movie> GetAllMovies();
        
        Movie GetMovieById(int id);
        
        void UpdateMovie(Movie movie);

        void DeleteMovie(Movie movieToDelete);

       void AddMovie(Movie movie);
        IEnumerable<Actor> GetAllActors(); 
        
        Actor GetActorById(int id);
        
        void UpdateActor(Actor actor);

        void DeleteActor(Actor actorToDelete);
        
       void AddActor(Actor actor);
        IEnumerable<Comment> GetAllComments();
        IEnumerable<MovieCast> GetAllMovieCasts();
        IEnumerable<MovieGenres> GetAllMovieGenres();

        IEnumerable<Theater> GetAllTheaters();

        IEnumerable<User> GetAllUsers();
}
