using System;
using Microsoft.EntityFrameworkCore;
using MigratedMoviesEFCore.Models;
using MongoDB.Bson;

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
        return _moviesDbContext.Movies.OrderBy(m => m.Title).AsNoTracking().AsEnumerable();
    }
    
    public Movie GetMovieById(string id)
    {
        return _moviesDbContext.Movies.Find(ObjectId.Parse(id));
    }

    public void UpdateMovie(string movieId, Movie movie)
    {
        var movieToUpdate = _moviesDbContext.Movies.FirstOrDefault((m => m.Id == ObjectId.Parse(movieId)));
        _moviesDbContext.Movies.Update(movieToUpdate);
        
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

    public string AddMovie(Movie movie)
    {
        _moviesDbContext.Movies.Add(movie);
        // Outputting for debugging purposes
        _moviesDbContext.ChangeTracker.DetectChanges();
        Console.WriteLine(_moviesDbContext.ChangeTracker.DebugView.LongView);

        _moviesDbContext.SaveChanges();

        return movie.Id.ToString();
    }
    public IEnumerable<Actor> GetAllActors()
    {
        return _moviesDbContext.Actors.OrderBy(a => a.DateOfBirth).AsNoTracking().AsEnumerable();
    }

    public Actor GetActorById(string id)
    {
        return _moviesDbContext.Actors.Find(ObjectId.Parse(id));
    }

    public void UpdateActor(string actorId, Actor actor)
    {
        var actorToUpdate = _moviesDbContext.Actors.FirstOrDefault(a => a.Id == ObjectId.Parse(actorId));
        _moviesDbContext.Actors.Update(actorToUpdate);
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

    public string AddActor(Actor actor)
    {
        _moviesDbContext.Actors.Add(actor);
        // Outputting for debugging purposes
        _moviesDbContext.ChangeTracker.DetectChanges();
        Console.WriteLine(_moviesDbContext.ChangeTracker.DebugView.LongView);
        
        _moviesDbContext.SaveChanges();
        
        return actor.Id.ToString();
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
