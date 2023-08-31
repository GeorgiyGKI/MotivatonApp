using Contracts;
using MotivatonApp.Shared.Models;

namespace MotivatonApp.Server.Service.ServiceMotivation
{
    public class MotivationService : IMotivationService
    {
        private readonly IRepositoryManager _repository;
        public MotivationService(IRepositoryManager repository) => _repository = repository;
       
        public async Task<Motivation> CreateMotivationAsync(Motivation motivation)
        {
            _repository.Motivation.CreateMotivation(motivation);
            await _repository.SaveAsync();

            return motivation;
        }

        public async Task DeleteMotivationAsync(int MotivationId)
        {
            var motivation = await _repository.Motivation.GetMotivationAsync(MotivationId);
            if (motivation is null)
                throw new NullReferenceException();

            _repository.Motivation.DeleteMotivation(motivation);
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<Motivation>> GetAllMotivationAsync()
        {
            var motivations = await _repository.Motivation.GetAllMotivationAsync();

            return motivations;
        }

        public async Task<Motivation> GetMotivationAsync(int MotivationId)
        {
            var motivation = await _repository.Motivation.GetMotivationAsync(MotivationId);
            if (motivation is null)
                throw new NullReferenceException();

            return motivation;
        }

        public async Task UpdateMotivationAsync(int MotivationId, Motivation MotivationForUpdate)
        {
            var motivationEntity = await _repository.Motivation.GetMotivationAsync(MotivationId);
            if (motivationEntity is null)
                throw new NullReferenceException();

            await _repository.SaveAsync();
        }
    }
}
