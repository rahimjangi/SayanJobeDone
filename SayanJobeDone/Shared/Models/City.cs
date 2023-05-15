using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SayanJobeDone.Shared.Models
{
    public class City
    {
        public int Id { get; set; }

        public int? CountryId { get; set; }
        [ForeignKey("CountryId")]
        public Country? Country { get; set; }

        [Required(ErrorMessage = "City name is required")]
        public string CityName { get; set; } = string.Empty;


    }
}
