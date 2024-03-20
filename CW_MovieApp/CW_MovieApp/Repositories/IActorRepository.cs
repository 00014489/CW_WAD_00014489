using CW_MovieApp.Modules;
using System.Diagnostics.Eventing.Reader;

namespace CW_MovieApp.Repositories
{
    public interface IActorsRepository
    {
        Task<IEnumerable<Actor>> GetAllActors();
        Task<Actor> GetSingleActor(int id);
        Task CreateActor(Actor actor);
        Task UpdateActor(Actor actor);
        Task DeleteActor(int id);
    }
}
