using System.ComponentModel.DataAnnotations;

namespace SayanJobeDone.Shared.Dtos
{
    public class LanguageDto
    {

        [Required(ErrorMessage = "Language name is required")]
        public string Name { get; set; } = string.Empty;
    }
}
