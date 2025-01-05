using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class ProjectImageSection
    {
        public int Id { get; set; }

        [Required]
        public string? ImageUrl { get; set; }

        public int ProjectId { get; set; }
        public ProjectSection? ProjectSection { get; set; }
    }
}
