using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class ContentBlockSection
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? SectionTitle { get; set; } // e.g., "WEB PRESENCE"

        [Required]
        public string? Description { get; set; } // The paragraph text

        public ICollection<ListItemSection>? Items { get; set; } // The list items
    }
}
