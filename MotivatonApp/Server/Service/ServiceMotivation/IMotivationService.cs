using MotivatonApp.Shared.Models;

namespace MotivatonApp.Server.Service.ServiceMotivation
{
    public interface IMotivationService
    {
        Task<IEnumerable<Motivation>> GetAllMotivationAsync();
        Task<Motivation> GetMotivationAsync(int MotivationId);
        Task<Motivation> CreateMotivationAsync(Motivation Motivation);
        Task DeleteMotivationAsync(int MotivationId);
        Task UpdateMotivationAsync(int MotivationId, Motivation MotivationForUpdate);
    }
}
