using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SayanJobeDone.Shared.Dtos
{
    public class SkillDto
    {

        [Required(ErrorMessage = "Skill name is required")]
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public CategoryDto? Category { get; set; }

        [Range(0, 5, ErrorMessage = "Experience level must be between 0 and 5")]
        public int ExperienceLevel { get; set; }


    }
}
