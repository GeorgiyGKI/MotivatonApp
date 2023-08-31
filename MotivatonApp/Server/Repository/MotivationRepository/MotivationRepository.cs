using Microsoft.EntityFrameworkCore;
using MotivatonApp.Shared.Models;
using Repository;

namespace MotivatonApp.Server.Repository.MotivationRepository
{
    public class MotivationRepository : RepositoryBase<Motivation>, IMotivationRepository
    {
        public MotivationRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Motivation>> GetAllMotivationAsync() =>
               await FindAll().ToListAsync();
        public async Task<Motivation> GetMotivationAsync(int motivationId) =>
               await FindByCondition(e => e.Id.Equals(motivationId))
               .SingleOrDefaultAsync();
        public void CreateMotivation(Motivation Motivation) => Create(Motivation);
        public void DeleteMotivation(Motivation Motivation) => Delete(Motivation);
    }
}