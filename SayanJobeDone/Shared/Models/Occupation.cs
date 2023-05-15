using System.ComponentModel.DataAnnotations;

namespace SayanJobeDone.Shared.Models
{
    public class OccupationDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Occupation name is required")]
        public string Name { get; set; } = string.Empty;
    }
}
