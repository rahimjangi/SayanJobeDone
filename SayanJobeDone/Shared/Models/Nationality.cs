﻿using System.ComponentModel.DataAnnotations;

namespace SayanJobeDone.Shared.Models
{
    public class Nationality
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nationality name is required")]
        public string Name { get; set; } = string.Empty;
    }
}
