using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CW_MovieApp.Data;
using CW_MovieApp.Modules;
using CW_MovieApp.Repositories;

namespace CW_MovieApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        private readonly MoviesListDbContext _context;
        private readonly IActorsRepository _actorRepository;

        public ActorsController(IActorsRepository actorRepository)
        {
            _actorRepository = actorRepository;
        }

        // GET: api/Actors
        [HttpGet]
        public async Task<IEnumerable<Actor>> GetActors()
        {
            return await _actorRepository.GetAllActors();
        }

        // GET: api/Actors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetActor(int id)
        {
            var actor = await _actorRepository.GetSingleActor(id);

            if (actor == null)
            {
                return NotFound();
            }

            return Ok(actor);
        }

        // PUT: api/Actors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovie(int id, Actor actor)
        {
            if (id != actor.Id)
            {
                return BadRequest();
            }

            await _actorRepository.UpdateActor(actor);
            return NoContent();
        }

        // POST: api/Actors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Actor>> PostActor(Actor actor)
        {
            _actorRepository.CreateActor(actor);

            return CreatedAtAction("GetActor", new { id = actor.Id }, actor);
        }

        // DELETE: api/Actors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActor(int id)
        {
            await _actorRepository.DeleteActor(id);
            return NoContent();
        }
    }
}
