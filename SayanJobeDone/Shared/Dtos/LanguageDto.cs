using System.ComponentModel.DataAnnotations;

namespace SayanJobeDone.Shared.Dtos
{
    public class LanguageDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Language name is required")]
        public string Name { get; set; } = string.Empty;
    }
}
