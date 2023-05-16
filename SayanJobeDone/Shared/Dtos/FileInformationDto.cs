using System.ComponentModel.DataAnnotations;

namespace SayanJobeDone.Shared.Dtos
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

        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public int GenderId { get; set; }

        public int NationalityId { get; set; }

        public int OccupationId { get; set; }

        public int LanguageId { get; set; }

        public int EducationLevelId { get; set; }

        public int EmploymentStatusId { get; set; }

        [Required(ErrorMessage = "Years of Experience is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Years of Experience must be a positive number")]
        public int YearsOfExperience { get; set; }

        public List<SkillDto>? Skills { get; set; }
        public List<PreviousEmploymentDto>? PreviousEmployments { get; set; }

    }
}
