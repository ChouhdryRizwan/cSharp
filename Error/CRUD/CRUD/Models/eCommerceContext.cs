using Microsoft.EntityFrameworkCore;

namespace CRUD.Models
{
    public class eCommerceContext : DbContext 
    {
        public eCommerceContext(DbContextOptions options) : base(options) {
        }


        public DbSet<Product> tbl_products { get; set; }
        public DbSet<Category> tbl_categories { get; set; }
    }
}
