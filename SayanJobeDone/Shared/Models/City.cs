using System.ComponentModel.DataAnnotations;

namespace SayanJobeDone.Shared.Models
{
    public class City
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "City name is required")]
        public string Name { get; set; } = string.Empty;


    }
}
