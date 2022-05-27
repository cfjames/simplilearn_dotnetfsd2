using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolEfDAL
{
    public class StudentModel
    {
        [Key]
        public int StudentID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Contact Email")]
        public string ContactEmail { get; set; }

        [Required]
        [StringLength(10)]
        public string Course { get; set; }

        [Required]
        [Range(0, 100)]
        public int Grades { get; set; }

        [NotMapped]
        public List<string> Subjects { get; set; }
    }
}
