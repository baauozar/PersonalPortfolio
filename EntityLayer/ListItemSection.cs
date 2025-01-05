using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class ListItemSection
    {
        public int Id { get; set; }

        [Required]
        public string? Text { get; set; } // e.g., "Frontend Development"

        public int ContentBlockId { get; set; }
        public ContentBlockSection? ContentBlockSection { get; set; }
    }
}
