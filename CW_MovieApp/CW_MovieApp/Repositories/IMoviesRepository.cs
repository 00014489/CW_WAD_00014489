using CW_MovieApp.Modules;
using System.Diagnostics.Eventing.Reader;

namespace CW_MovieApp.Repositories
{
    public interface IMoviesRepository
    {
        Task<IEnumerable<Movie>> GetAllMovies();
        Task<Movie> GetSingleMovie(int id);
        Task CreateMovie(Movie movie);
        Task UpdateMovie(Movie movie);
        Task DeleteMovie(int id);
    }
}
