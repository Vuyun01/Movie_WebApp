using Microsoft.EntityFrameworkCore;
using Movies_WebApp.Models;

namespace Movies_WebApp.Data.Services
{
    public class ActorService : IActorService
    {
        private readonly ApplicationDbContext _context;

        public ActorService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _context.Actors.FirstOrDefaultAsync(a => a.ActorID == id);
            _context.Actors.Remove(data);
            await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var data = await _context.Actors.ToListAsync();
            return data;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var data = await _context.Actors.FirstOrDefaultAsync(a => a.ActorID == id);
            return data;
        }

        public async Task UpdateAsync(Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
        }
    }
}
