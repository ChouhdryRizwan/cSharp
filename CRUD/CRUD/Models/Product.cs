using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string prodName { get; set; }
        public string prodImage { get; set; }
    }
}
