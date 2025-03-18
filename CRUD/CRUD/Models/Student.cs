
using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Student
    {
        [Key]
        public int sid { get; set; }

        [Required(ErrorMessage ="Name tw lazmi chayiea")]
        [StringLength(10,MinimumLength =3, ErrorMessage ="ye apna message ha")]
        public string sname { get; set; }
        public string semail{ get; set; }

        public string sbatch { get; set; }
    }
}


