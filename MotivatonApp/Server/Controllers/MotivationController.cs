using Microsoft.AspNetCore.Mvc;
using MotivatonApp.Shared.Models;
using MotivatonApp.Server.Service.ServiceMotivation;

namespace MotivatonApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MotivationController
    {
        private readonly IMotivationService _service;

        public MotivationController(IMotivationService service) => _service = service;

        [HttpGet("{id:int}")]
        public async Task<Motivation> GetCategory(int id)
        {
            var motivation = await _service.GetMotivationAsync(id);
            return (motivation);
        }
    }
}
