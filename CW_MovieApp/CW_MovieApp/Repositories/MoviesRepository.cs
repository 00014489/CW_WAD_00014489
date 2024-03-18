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
        public async Task<IEnumerable<Movie>> GetAllMovies()
        {
            var movies = await _dbContext.Movies.ToListAsync();
            return movies;
        }

        public async Task<Movie> GetSingleMovie(int id)
        {
            return await _dbContext.Movies.FirstOrDefaultAsync( b => b.Id == id);
        }

        public async Task CreateMovie(Movie movie)
        {
            await _dbContext.Movies.AddAsync(movie);
            await _dbContext.SaveChangesAsync();
        }
        public async Task UpdateMovie(Movie movie)
        {
            _dbContext.Entry(movie).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
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
