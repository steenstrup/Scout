using Microsoft.EntityFrameworkCore;
using Scout.Shared.Models;
using System.Collections.Generic;
using System.Linq;

namespace Scout.Server
{
    public class ScoutContext : DbContext
    {
        public ScoutContext(DbContextOptions<ScoutContext> options) : base(options)
        {
            
        }

        public void LoadSampleData()
        {
            if (Scouts.Count() != 0)
            {
                return;
            }

            Tags.Add(badges[0].Tags[0]);
            Tags.Add(badges[0].Tags[1]);
            Tags.Add(badges[1].Tags[0]);
            Tags.Add(badges[1].Tags[1]);
            Badges.Add(badges[0]);
            Badges.Add(badges[1]);
            Scouts.Add(scouts[0]);
            Scouts.Add(scouts[1]);

            //SaveChanges();
        }

        private static readonly List<Scoutt> scouts = new List<Scoutt>
        {
            new Scoutt()
            {
                Name = "Bob",
                Badges = new List<Badge>() {badges[0] }
            },
            new Scoutt()
            {
                Name = "Bent",
                Badges = new List<Badge>() {badges[1] }
            }
        };

        private static readonly List<Badge> badges = new List<Badge>()
        {
            new Badge(){
            Name = "bål",
            Image = "https://dds.dk/sites/default/files/2018-06/B%C3%A5l%405x.png",
            Tags = new List<Tag>(){
                new Tag() { Name = "DDS"},
                new Tag() { Name = "Blå-spejder"}
            }
            },
            new Badge(){
            Name = "Bygherre",
            Image = "https://d33wubrfki0l68.cloudfront.net/a5e2f67eddbb5f8aeaa6ccb63f628f503f4d5814/d62db/img/compressed/dds-bygherre.jpg",
            Tags = new List<Tag>(){
                new Tag() { Name = "Duelighed"},
                new Tag() { Name = "DDDS-færdighedesmærke" }
            }
            }
        };


        public DbSet<Badge> Badges { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<Scoutt> Scouts { get; set; }

    }
}
