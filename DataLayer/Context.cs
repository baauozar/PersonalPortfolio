using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<HeroSection> Heroes { get; set; }
        public DbSet<AboutSection> Abouts { get; set; }
        public DbSet<ProjectSection> Projects { get; set; }
        public DbSet<EducationSection> Educations { get; set; }
        public DbSet<CircleSection> Circles { get; set; } 
        public DbSet<SkillSection> Skills { get; set; } 
        public DbSet<ListItemSection> ListItems { get; set; } 
        public DbSet<ProjectImageSection> ProjectImages { get; set; } 
        public DbSet<ContentBlockSection> ContentBlocks { get; set; } 
    }
}
