using CW_MovieApp.Data;
using CW_MovieApp.Modules;
using Microsoft.EntityFrameworkCore;

namespace CW_MovieApp.Repositories
{
    public class ActorsRepository : IActorsRepository
    {
        private readonly MoviesListDbContext _dbContext;

        public ActorsRepository(MoviesListDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Get all
        public async Task<IEnumerable<Actor>> GetAllActors()
        {
            var actors = await _dbContext.Actors.ToListAsync();
            return actors;
        }

        //Get by ID
        public async Task<Actor> GetSingleActor(int id)
        {
            return await _dbContext.Actors.FirstOrDefaultAsync( a => a.Id == id);
        }

        //Create
        public async Task CreateActor(Actor actor)
        {
            await _dbContext.Actors.AddAsync(actor);
            await _dbContext.SaveChangesAsync();
        }
        //Edit
        public async Task UpdateActor(Actor actor)
        {
            _dbContext.Entry(actor).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
        //Delete
        public async Task DeleteActor(int id)
        {
            var actor = await _dbContext.Actors.FirstOrDefaultAsync(a => a.Id == id);
            if (actor != null)
            {
                _dbContext.Actors.Remove(actor);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
