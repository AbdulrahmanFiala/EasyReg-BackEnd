using System.ComponentModel.DataAnnotations;

namespace EasyReg_BackEnd.Entities
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [RegularExpression(@"^(010|011|012|015)\d{8}$", ErrorMessage = "Invalid egyptian phone format")]
        public required string Phone { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(16, 80, ErrorMessage = "Age must be between 16 and 80")]
        public required byte Age { get; set; }
    }
}
