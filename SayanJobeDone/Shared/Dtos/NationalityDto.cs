using System.ComponentModel.DataAnnotations;

namespace SayanJobeDone.Shared.Dtos
{
    public class NationalityDto
    {

        [Required(ErrorMessage = "Nationality name is required")]
        public string Name { get; set; } = string.Empty;
    }
}
