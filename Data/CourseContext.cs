using Microsoft.EntityFrameworkCore;
using BagiTugas.Models;

namespace BagiTugas.Data
{
    public class CourseContext : DbContext
    {
        public CourseContext(DbContextOptions<CourseContext> options)
            : base(options)
        {
            
        }
        
        public DbSet<Course> Course { get; set; }
    }
}