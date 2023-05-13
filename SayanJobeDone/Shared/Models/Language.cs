using System.ComponentModel.DataAnnotations;

namespace SayanJobeDone.Shared.Models
{
    public class Language
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Language name is required")]
        public string Name { get; set; } = string.Empty;
    }
}
