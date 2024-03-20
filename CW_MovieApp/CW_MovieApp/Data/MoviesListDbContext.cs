using CW_MovieApp.Modules;
using Microsoft.EntityFrameworkCore;

namespace CW_MovieApp.Data
{
    public class MoviesListDbContext : DbContext
    {
        public MoviesListDbContext(DbContextOptions<MoviesListDbContext> options) : base(options) { }
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Actor> Actors { get; set; }
    }
}
