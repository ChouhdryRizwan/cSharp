using Microsoft.EntityFrameworkCore;

namespace CRUD.Models
{
    public class myContext : DbContext
    {
        public myContext(DbContextOptions<myContext> options) : base(options){
        
        }
        public DbSet<Student> tbl_Students { get; set; }
        public DbSet<Product> tbl_Products { get; set; }
    }
}
