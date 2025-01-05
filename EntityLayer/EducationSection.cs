using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EducationSection
    {
        public int Id { get; set; }

        [Required]
        public string? Institution { get; set; }

        public string? Degree { get; set; }

        public string? Duration { get; set; }

        public string? Description { get; set; }
    }
}
