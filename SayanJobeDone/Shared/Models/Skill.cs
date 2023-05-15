using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SayanJobeDone.Shared.Models
{
    public class SkillDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Skill name is required")]
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public CategoryDto? Category { get; set; }

        [Range(0, 5, ErrorMessage = "Experience level must be between 0 and 5")]
        public int ExperienceLevel { get; set; }

        [Required(ErrorMessage = "Creation date is required")]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        [Required(ErrorMessage = "Last updated date is required")]
        [DataType(DataType.Date)]
        public DateTime LastUpdatedDate { get; set; }

    }
}
