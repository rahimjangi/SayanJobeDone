using System.ComponentModel.DataAnnotations;

namespace SayanJobeDone.Shared.Models
{
    public class Country
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Country name is required")]
        public string Name { get; set; } = string.Empty;
        public List<City>? Cities { get; set; } = new List<City>();
    }
}
