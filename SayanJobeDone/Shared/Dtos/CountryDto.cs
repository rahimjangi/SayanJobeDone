using System.ComponentModel.DataAnnotations;

namespace SayanJobeDone.Shared.Dtos
{
    public class CountryDto
    {

        [Required(ErrorMessage = "Country name is required")]
        public string Name { get; set; } = string.Empty;
        public List<CityDto>? Cities { get; set; } = new List<CityDto>();
    }
}
