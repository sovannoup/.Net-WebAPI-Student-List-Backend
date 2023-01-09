using Backend_Student_List.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Student_List.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
