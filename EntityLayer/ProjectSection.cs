using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class ProjectSection
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? Year { get; set; }
        public string? Title { get; set; }

        public ICollection<SkillSection>? Skills { get; set; }

        public ICollection<ProjectImageSection>? Images { get; set; }
    }
}
