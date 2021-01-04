using Microsoft.EntityFrameworkCore;
using Scout.Shared.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Scout.Server.Services
{
    public class ScoutService : IScoutService
    {
        private readonly ScoutContext _context;

        public ScoutService(ScoutContext context)
        {
            _context = context;
            _context.LoadSampleData();
        }

        public async Task<ServiceResponse<List<Scoutt>>> Get()
        {
            ServiceResponse<List<Scoutt>> serviceResponseBadges = new ServiceResponse<List<Scoutt>>
            {
                Data = await _context.Scouts.Include(s => s.Badges).ToListAsync()
            };
            return serviceResponseBadges;
        }

        public async void Put(Scoutt scout)
        {
        }
    }
}
