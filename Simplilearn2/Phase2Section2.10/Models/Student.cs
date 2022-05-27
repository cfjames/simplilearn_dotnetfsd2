using System;
using System.Collections.Generic;

namespace Phase2Section2._10.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Course { get; set; } = null!;
    }
}
