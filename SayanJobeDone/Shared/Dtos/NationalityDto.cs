using System.ComponentModel.DataAnnotations;

namespace SayanJobeDone.Shared.Dtos
{
    public class NationalityDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nationality name is required")]
        public string Name { get; set; } = string.Empty;
    }
}
