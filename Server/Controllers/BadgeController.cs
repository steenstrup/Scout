using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Scout.Server.Services;
using Scout.Shared.Models;

namespace Scout.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BadgeController : ControllerBase
    {
        private readonly IBadgeService _badgeService;
        public BadgeController(IBadgeService badgeService)
        {
            _badgeService = badgeService;
        }

        [HttpGet]
        public async Task<ServiceResponse<List<Badge>>> Get()
        {
            return await _badgeService.Get();
        }

        [HttpPut]
        public async void Put(Badge badge)
        {
            _badgeService.Put(badge);
        }

    }
}
