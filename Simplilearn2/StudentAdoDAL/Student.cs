using System.ComponentModel.DataAnnotations;

namespace StudentAdoDAL
{
    public class Student
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Course { get; set; }

        [Required]
        public int Grades { get; set; }
    }
}