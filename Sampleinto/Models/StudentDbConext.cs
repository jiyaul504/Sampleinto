using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;

namespace Sampleinto.Models
{
    public class StudentDbConext:DbContext
    {
        public StudentDbConext(DbContextOptions<StudentDbConext> options) : base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
