using Microsoft.EntityFrameworkCore;

namespace CRUD.Models
{
    public class myContext : DbContext
    {
        public myContext(DbContextOptions<myContext> options) : base(options){
        
        }  
    }
}
