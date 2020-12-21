using System.Collections.Generic;

namespace Scout.Shared.Models
{
    public class Badge
    {
        public string Image { get; set; }

        public string Name { get; set; }

        public List<Tag> Tags { get; set; }

        public int AgeGroupFrom { get; set; } = 10;

        public int AgeGroupTo { get; set; } = 12;

        public string Description { get; set; }

        public string Link { get; set; }

        public int Id { get; set; }
    }
}
