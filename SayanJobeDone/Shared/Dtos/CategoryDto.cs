using System.ComponentModel.DataAnnotations;

namespace SayanJobeDone.Shared.Dtos
{
    public class CategoryDto
    {

        [Required(ErrorMessage = "Category name is required")]
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

    }
}
