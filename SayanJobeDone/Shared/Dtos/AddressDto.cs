using System.ComponentModel.DataAnnotations;

namespace SayanJobeDone.Shared.Dtos

{
    public class AddressDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Street is required")]
        public string Street { get; set; } = string.Empty;

        [Required(ErrorMessage = "Postal code is required")]
        public string PostalCode { get; set; } = string.Empty;

        public int? CountryId { get; set; }
        public int? CityId { get; set; }

    }
}
