using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class AboutSection
    {
        public int Id { get; set; }

        [Required]
        public string? Heading { get; set; } // e.g., "About Me"

        public string? Description { get; set; } // Detailed description

        public string? ImageUrl { get; set; } // URL to the profile image
    }
}
