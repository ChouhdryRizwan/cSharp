using Microsoft.EntityFrameworkCore;

namespace UsersApplication.Models
{
    public class UserDBContext : DbContext
    {
        public UserDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
