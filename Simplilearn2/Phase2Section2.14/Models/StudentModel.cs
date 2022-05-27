using System.ComponentModel.DataAnnotations;

namespace Phase2Section2._14.Models
{
    public class StudentModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Course { get; set; }

        [Required]     
        [EmailAddress(ErrorMessage = "Please provide a valid email")]
        [Display(Name = "Contact Email")]
        public string ContactEmail { get; set; }

        [Required]
        [Range(5,14, ErrorMessage = "Student must be between 5 and 14")]
        public int Age { get; set; }
    }
}
