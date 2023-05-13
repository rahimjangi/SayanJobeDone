using System.ComponentModel.DataAnnotations;

namespace SayanJobeDone.Shared.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Street is required")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Postal code is required")]
        public string PostalCode { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }
    }
}
