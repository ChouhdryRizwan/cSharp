using System.ComponentModel.DataAnnotations;

namespace ModelApp.Models
{
    public class product
    {
        [Key]
        public int c_id { get; set; }

        [Required]
        public string name { get; set; }
    }
}
