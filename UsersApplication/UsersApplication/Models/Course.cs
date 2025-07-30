using System.ComponentModel.DataAnnotations;

namespace UsersApplication.Models
{
    public class Course
    {
        [Key]
        public Guid Id { get; set; }

        public string CourseName { get; set; }
    }
}
