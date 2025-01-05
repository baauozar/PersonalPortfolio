using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class HeroSection
    {
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; } // e.g., "Art Director and Digital Designer"

        public string? Subtitle { get; set; } // e.g., "Based in..."

        public string? Introduction { get; set; } // e.g., "Hello, I am ..."

        public string? ImageUrl { get; set; } // URL to the hero image

    }
}
