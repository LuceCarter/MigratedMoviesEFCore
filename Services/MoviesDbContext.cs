using Microsoft.EntityFrameworkCore;
using MigratedMoviesEFCore.Models;

namespace MigratedMoviesEFCore.Services;

public class MoviesDbContext : DbContext
{
     public DbSet<Actor> Actors { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<MovieCast> MovieCasts { get; set; }
    public DbSet<MovieGenres> MovieGenres { get; set; }
    public DbSet<Theater> Theaters { get; set; }
    public DbSet<User>  Users { get; set; }
}
