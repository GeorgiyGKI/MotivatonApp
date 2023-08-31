using Contracts;
using MotivatonApp.Server.Repository.MotivationRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository 
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IMotivationRepository> _motivationRepository;
        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _motivationRepository = new Lazy<IMotivationRepository>(() => new MotivationRepository(repositoryContext));

        }
        public IMotivationRepository Motivation => _motivationRepository.Value;
        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
    }
}
