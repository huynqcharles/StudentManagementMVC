using Microsoft.EntityFrameworkCore;
using StudentManagement.MVC.Models;

namespace StudentManagement.MVC.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
