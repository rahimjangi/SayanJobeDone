using System.ComponentModel.DataAnnotations;

namespace SayanJobeDone.Shared.Dtos
{
    public class CityDto
    {
        public int Id { get; set; }

        public int? CountryId { get; set; }
        [Required(ErrorMessage = "City name is required")]
        public string CityName { get; set; } = string.Empty;


    }
}
