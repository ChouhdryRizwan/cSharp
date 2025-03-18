using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Validations
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string FullName { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Range(18, 60, ErrorMessage = "Age must be between 18 and 60")]
        public int Age { get; set; }

        [RegularExpression(@"^[A-Za-z0-9]+$", ErrorMessage = "Username can only contain letters and numbers")]
        public string Username { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }

        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string PhoneNumber { get; set; }

        [Url(ErrorMessage = "Invalid URL format")]
        public string Website { get; set; }
    }
}
