﻿using System.ComponentModel.DataAnnotations;
using WebAPI.Models.Validations;

namespace WebAPI.Models
{
    public class Shirt
    {
        public int ShirtId { get; set; }

        [Required]
        public string? Brand { get; set; }
        [Shirt_EnsureCorrectSizing]
        public string? Color { get; set; }
        public int? Size { get; set; }
        [Required]
        public string? Gender { get; set; }
        public double? Price { get; set; }
    }
}
