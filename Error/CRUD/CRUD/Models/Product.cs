using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD.Models
{
    public class Product
    {
        [Key]
        public Guid id { get; set; }

        [Column("ProductName",TypeName ="Varchar(120)")]
        public string name { get; set; }
        
        [Column("ProductDescription", TypeName = "Varchar(220)")]
        public string? description { get; set; }

        [Column("ProductPrice", TypeName = "decimal")]
        public float price { get; set; }

        [Column("ProductImage", TypeName = "Varchar(220)")]
        public string? image { get; set; }

        [Column("ProductStock")]
        public int stock { get; set; }


        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }

        public Category Category { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}
