using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Scout.Server.Services;
using Scout.Shared.Models;

namespace Scout.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ScouttController : ControllerBase
    {
        private readonly IScoutService _scoutService;
        public ScouttController(IScoutService scoutService)
        {
            _scoutService = scoutService;
        }

        [HttpGet]
        public async Task<ServiceResponse<List<Scoutt>>> Get()
        {
            return await _scoutService.Get();
        }

        [HttpPut]
        public async void Put(Scoutt scout)
        {
            _scoutService.Put(scout);
        }

    }
}
