using CW_MovieApp.Data;
using CW_MovieApp.Modules;
using Microsoft.EntityFrameworkCore;

namespace CW_MovieApp.Repositories
{
    public class MoviesRepository : IMoviesRepository
    {
        private readonly MoviesListDbContext _dbContext;

        public MoviesRepository(MoviesListDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Get all
        public async Task<IEnumerable<Movie>> GetAllMovies()
        {
            var movies = await _dbContext.Movies.Include(b => b.Actor).ToListAsync();
            return movies;
        }

        //Get by ID
        public async Task<Movie> GetSingleMovie(int id)
        {
            return await _dbContext.Movies.Include(b => b.Actor).FirstOrDefaultAsync( b => b.Id == id);
        }

        //Create
        public async Task CreateMovie(Movie movie)
        {
            await _dbContext.Movies.AddAsync(movie);
            await _dbContext.SaveChangesAsync();
        }

        //Edit
        public async Task UpdateMovie(Movie movie)
        {
            _dbContext.Entry(movie).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
        //Delete
        public async Task DeleteMovie(int id)
        {
            var movie = await _dbContext.Movies.FirstOrDefaultAsync(b=>b.Id == id);
            if (movie != null)
            {
                _dbContext.Movies.Remove(movie);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
