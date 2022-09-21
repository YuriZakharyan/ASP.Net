using Microsoft.EntityFrameworkCore;

namespace StudentsApiDemo.Models
{
    public class StudentContext : DbContext 
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }
        public DbSet<StudentItem> StudentItems { get; set; } = null;


    }
}
