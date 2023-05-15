using System.ComponentModel.DataAnnotations;

namespace SayanJobeDone.Shared.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Category name is required")]
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Creation date is required")]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        [Required(ErrorMessage = "Last updated date is required")]
        [DataType(DataType.Date)]
        public DateTime LastUpdatedDate { get; set; }
    }
}
