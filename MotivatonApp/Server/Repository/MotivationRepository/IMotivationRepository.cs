using MotivatonApp.Shared.Models;

namespace MotivatonApp.Server.Repository.MotivationRepository
{
    public interface IMotivationRepository
    {
        Task<IEnumerable<Motivation>> GetAllMotivationAsync();
        Task<Motivation> GetMotivationAsync(int motivationId);
        void CreateMotivation(Motivation motivation);
        void DeleteMotivation(Motivation motivation);
    }
}
