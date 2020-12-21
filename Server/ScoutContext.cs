using Microsoft.EntityFrameworkCore;
using Scout.Shared.Models;

namespace Scout.Server
{
    public class ScoutContext : DbContext
    {
        public ScoutContext(DbContextOptions<ScoutContext> options) : base(options) { }

        public DbSet<Badge> Badges { get; set; }
        public DbSet<Tag> Tags { get; set; }

    }
}
