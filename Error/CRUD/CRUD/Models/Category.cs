using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD.Models
{
    public class Category
    {
        [Key]
        public Guid id { get; set; }

        [Column("CategoryName",TypeName ="Varchar(50)")]
        public string catname { get; set; }

    }
}
