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

            LoadSampleData();
        }

        private void LoadSampleData()
        {
            if (_context.Badges.Count() == 0)
            {
                return;
            }

            _context.Tags.Add(tags[0]);
            _context.Tags.Add(tags[1]);
            _context.Tags.Add(tags[2]);
            _context.Tags.Add(tags[3]);
            _context.Badges.Add(badges[0]);
            _context.Badges.Add(badges[1]);
            _context.SaveChanges();
        }

        public static readonly List<Tag> tags = new List<Tag>()
        {
            new Tag() { Name = "DDS"},
            new Tag() { Name = "Blå-spejder"},
            new Tag() { Name = "Duelighed"},
            new Tag() { Name = "DDDS-færdighedesmærke" }

        };

        public static readonly List<Badge> badges = new List<Badge>()
        {
            new Badge(){
            Name = "bål",
            Image = "https://dds.dk/sites/default/files/2018-06/B%C3%A5l%405x.png",
            Tags = tags,
            },
            new Badge(){
            Name = "Bygherre",
            Image = "https://d33wubrfki0l68.cloudfront.net/a5e2f67eddbb5f8aeaa6ccb63f628f503f4d5814/d62db/img/compressed/dds-bygherre.jpg",
            Tags = tags,
            }
        };

        public async Task<ServiceResponse<List<Badge>>> Get()
        {

            ServiceResponse<List<Badge>> serviceResponseBadges = new ServiceResponse<List<Badge>>
            {
                Data = await _context.Badges.ToListAsync()
            };
            return serviceResponseBadges;
        }
    }
}
