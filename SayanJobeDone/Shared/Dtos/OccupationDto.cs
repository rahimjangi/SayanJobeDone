using System.ComponentModel.DataAnnotations;

namespace SayanJobeDone.Shared.Dtos
{
    public class OccupationDto
    {

        [Required(ErrorMessage = "Occupation name is required")]
        public string Name { get; set; } = string.Empty;
    }
}
