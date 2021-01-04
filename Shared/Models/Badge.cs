using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Scout.Shared.Models
{
    public class Badge
    {
        [Required]
        public string Image { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Tag> Tags { get; set; }

        [Range(1, 100000, ErrorMessage = "Age most be between (1-100000).")]
        public int AgeGroupFrom { get; set; } = 10;

        [Range(1, 100000, ErrorMessage = "Age most be between  (1-100000).")]
        public int AgeGroupTo { get; set; } = 12;

        [Required]
        public string Description { get; set; } = "";

        [Required]
        public string Link { get; set; } = "";

        public int Id { get; set; } = 0;
    }
}
