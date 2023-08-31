using MotivatonApp.Server.Repository.MotivationRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IMotivationRepository Motivation { get; }
        Task SaveAsync();
    }
}
