using Microsoft.EntityFrameworkCore;

namespace ModelApp.Models
{
    public class db_commerce : DbContext
    {
        public db_commerce(DbContextOptions<db_commerce> options ):base(options) { }
        public DbSet<product> Products { get; set; }
        

    }
}
