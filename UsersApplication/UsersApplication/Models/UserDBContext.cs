using Microsoft.EntityFrameworkCore;
using UsersApplication.Migrations;

namespace UsersApplication.Models
{
    public class UserDBContext : DbContext
    {
        public UserDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
