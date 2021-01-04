using Microsoft.EntityFrameworkCore;
using Scout.Shared.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scout.Server.Services
{
    public class BadgeService : IBadgeService
    {
        private readonly ScoutContext _context;

        public BadgeService(ScoutContext context)
        {
            _context = context;
            _context.LoadSampleData();
        }


        public async Task<ServiceResponse<List<Badge>>> Get()
        {
            ServiceResponse<List<Badge>> serviceResponseBadges = new ServiceResponse<List<Badge>>
            {
                Data = await _context.Badges.Include(b => b.Tags).ToListAsync()
            };
            return serviceResponseBadges;
        }

        public async void Put(Badge badge)
        {
            //if(badge.Tags == null)
            //    badge.Tags = tags;
            _context.Badges.Add(badge);
            _context.SaveChanges();
        }

    }
}
