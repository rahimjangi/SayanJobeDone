using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SayanJobeDone.Shared.Models
{
    public class AddressDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Street is required")]
        public string Street { get; set; } = string.Empty;

        [Required(ErrorMessage = "Postal code is required")]
        public string PostalCode { get; set; } = string.Empty;

        public int? CountryId { get; set; }
        [ForeignKey("CountryId")]
        public virtual CountryDto? Country { get; set; }

        public int? CityId { get; set; }
        [ForeignKey("CityId")]
        public virtual CityDto? City { get; set; }
    }
}
