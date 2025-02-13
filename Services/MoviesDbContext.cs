using Microsoft.EntityFrameworkCore;
using MigratedMoviesEFCore.Models;

namespace MigratedMoviesEFCore.Services;

public class MoviesDbContext : DbContext
{
     public DbSet<Actor> Actors { get; set; }
    public DbSet<Movie> Movies { get; set; }
    
    public DbSet<Theater> Theaters { get; set; }
    public DbSet<User>  Users { get; set; }

    public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>().HasMany(m => m.Comments).WithOne().IsRequired(false);
      
    }

}
