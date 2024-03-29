﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Phase2Section2._10.Models
{
    public class StudentMetadata
    {
        [Required]
        public int Id { get; set; }

        [StringLength(5)]
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Course { get; set; } = null!;
    }
}
