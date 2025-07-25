using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UsersApplication.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Column("StudentName", TypeName="varchar(120)")]
        public string Name { get; set; }
        [Column("StudentEmail", TypeName = "varchar(50)")]
        public string Email { get; set; }
        [Column("Mobile", TypeName = "varchar(50)")]
        public string PhoneNumber { get; set; }
        [Column("StudentAddress", TypeName = "varchar(250)")]
        public string Address { get; set; }

        [Column("StudentImage", TypeName = "varchar(250)")]
        public string? image { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
