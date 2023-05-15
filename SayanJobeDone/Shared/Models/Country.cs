using System.ComponentModel.DataAnnotations;

namespace SayanJobeDone.Shared.Models
{
    public class CountryDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Country name is required")]
        public string Name { get; set; } = string.Empty;
        public List<CityDto>? Cities { get; set; } = new List<CityDto>();
    }
}
