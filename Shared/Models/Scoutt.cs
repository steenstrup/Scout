using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Scout.Shared.Models
{
    public class Scoutt
    {
        [Required]
        public string Name { get; set; }

        public List<Badge> Badges { get; set; }

        public int Id { get; set; } = 0;

    }
}
