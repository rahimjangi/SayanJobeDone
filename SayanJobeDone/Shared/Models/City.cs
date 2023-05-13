using System.ComponentModel.DataAnnotations;

namespace SayanJobeDone.Shared.Models
{
    public class City
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "City name is required")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Country is required")]
        public int CountryId { get; set; }

        public Country? Country { get; set; }
    }
}
