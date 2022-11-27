using Movies_WebApp.Models;

namespace Movies_WebApp.Data.Services
{
    public interface IActorService
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Task UpdateAsync(Actor newActor);
        Task DeleteAsync(int id);
    }
}
