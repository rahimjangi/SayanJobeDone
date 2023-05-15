using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SayanJobeDone.Shared.Models
{
    public class FileInformationDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; } = string.Empty;
        public string Nickname { get; set; } = string.Empty;
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; } = string.Empty;

        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = string.Empty;

        [Phone(ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; } = string.Empty;
        public int AddressId { get; set; }
        [Required(ErrorMessage = "Address is required")]
        [ForeignKey("AddressId")]
        public AddressDto? Address { get; set; }
        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public int GenderId { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        [ForeignKey("GenderId")]
        public GenderDto? Gender { get; set; }
        public int NationalityId { get; set; }

        [Required(ErrorMessage = "Nationality is required")]
        [ForeignKey("NationalityId")]
        public NationalityDto? Nationality { get; set; }
        public int OccupationId { get; set; }

        [Required(ErrorMessage = "Occupation is required")]
        [ForeignKey("OccupationId")]
        public OccupationDto? Occupation { get; set; }
        public int LanguageId { get; set; }

        [Required(ErrorMessage = "Preferred Language is required")]
        [ForeignKey("LanguageId")]
        public LanguageDto? Language { get; set; }
        public int EducationLevelId { get; set; }

        [Required(ErrorMessage = "Education Level is required")]
        [ForeignKey("EducationLevelId")]
        public EducationLevelDto? EducationLevel { get; set; }
        public int EmploymentStatusId { get; set; }

        [Required(ErrorMessage = "Employment Status is required")]
        [ForeignKey("EmploymentStatusId")]
        public EmploymentStatusDto? EmploymentStatus { get; set; }

        [Required(ErrorMessage = "Years of Experience is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Years of Experience must be a positive number")]
        public int YearsOfExperience { get; set; }

        public List<SkillDto>? Skills { get; set; }
        public List<PreviousEmploymentDto>? PreviousEmployments { get; set; }

    }
}
