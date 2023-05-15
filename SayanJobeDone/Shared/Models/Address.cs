using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SayanJobeDone.Shared.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Street is required")]
        public string Street { get; set; } = string.Empty;

        [Required(ErrorMessage = "Postal code is required")]
        public string PostalCode { get; set; } = string.Empty;

        public int? CountryId { get; set; }
        [ForeignKey("CountryId")]
        public virtual Country? Country { get; set; }

        public int? CityId { get; set; }
        [ForeignKey("CityId")]
        public virtual City? City { get; set; }
    }
}
