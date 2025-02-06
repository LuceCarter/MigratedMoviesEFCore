using System;
using Microsoft.EntityFrameworkCore;
using MigratedMoviesEFCore.Models;

namespace MigratedMoviesEFCore.Services;

public class MovieService : IMovieService
{
    private readonly MoviesDbContext _moviesDbContext;

    public MovieService(MoviesDbContext moviesDbContext)
    {
        _moviesDbContext = moviesDbContext;
    }

    public IEnumerable<Movie> GetAllMovies()
    {
        return _moviesDbContext.Movies.OrderBy(m => m.MovieId).AsNoTracking().AsEnumerable();
    }
    
    public Movie GetMovieById(int id)
    {
        return _moviesDbContext.Movies.Find(id);
    }

    public void UpdateMovie(Movie movie)
    {
        _moviesDbContext.Movies.Update(movie);
        
        _moviesDbContext.ChangeTracker.DetectChanges();
        Console.WriteLine(_moviesDbContext.ChangeTracker.DebugView.LongView);

        _moviesDbContext.SaveChanges();
    }

    public void DeleteMovie(Movie  movieToDelete)
    {
        _moviesDbContext.Movies.Remove(movieToDelete);
        
        _moviesDbContext.ChangeTracker.DetectChanges();
        Console.WriteLine(_moviesDbContext.ChangeTracker.DebugView.LongView);

        _moviesDbContext.SaveChanges();
    }

    public void AddMovie(Movie movie)
    {
        _moviesDbContext.Movies.Add(movie);
        // Outputting for debugging purposes
        _moviesDbContext.ChangeTracker.DetectChanges();
        Console.WriteLine(_moviesDbContext.ChangeTracker.DebugView.LongView);

        _moviesDbContext.SaveChanges();
    }
    public IEnumerable<Actor> GetAllActors()
    {
        return _moviesDbContext.Actors.OrderBy(a => a.DateOfBirth).AsNoTracking().AsEnumerable();
    }

    public Actor GetActorById(int id)
    {
        return _moviesDbContext.Actors.Find(id);
    }

    public void UpdateActor(Actor actor)
    {
        _moviesDbContext.Actors.Update(actor);
        // Outputting for debugging purposes
        _moviesDbContext.ChangeTracker.DetectChanges();
        Console.WriteLine(_moviesDbContext.ChangeTracker.DebugView.LongView);

        _moviesDbContext.SaveChanges();
    }

    public void DeleteActor(Actor actorToDelete)
    {
        _moviesDbContext.Actors.Remove(actorToDelete);
        
        _moviesDbContext.ChangeTracker.DetectChanges();
        Console.WriteLine(_moviesDbContext.ChangeTracker.DebugView.LongView);

        _moviesDbContext.SaveChanges();
    }

    public void AddActor(Actor actor)
    {
        _moviesDbContext.Actors.Add(actor);
        // Outputting for debugging purposes
        _moviesDbContext.ChangeTracker.DetectChanges();
        Console.WriteLine(_moviesDbContext.ChangeTracker.DebugView.LongView);
        
        _moviesDbContext.SaveChanges();
    }
    public IEnumerable<Comment> GetAllComments()
    {
        return _moviesDbContext.Comments.OrderBy(c => c.CommentDate).AsNoTracking().AsEnumerable();
    }
    
    public IEnumerable<MovieCast> GetAllMovieCasts()
    {
        return _moviesDbContext.MovieCasts.OrderBy(mc => mc.MovieId).AsNoTracking().AsEnumerable();
    }
    
    public IEnumerable<MovieGenres> GetAllMovieGenres()
    {
        return _moviesDbContext.MovieGenres.OrderBy(mg => mg.MovieId).AsNoTracking().AsEnumerable();
    }
    
    public IEnumerable<Theater> GetAllTheaters()
    {
        return _moviesDbContext.Theaters.OrderBy(t => GetType().Name).AsNoTracking().AsEnumerable();
    }
    
    public IEnumerable<User> GetAllUsers()
    {
        return _moviesDbContext.Users.OrderBy(u => u.Name).AsNoTracking().AsEnumerable();
    }
}
