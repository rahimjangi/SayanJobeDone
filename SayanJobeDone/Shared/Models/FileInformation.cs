using System.ComponentModel.DataAnnotations;

namespace SayanJobeDone.Shared.Models
{
    public class FileInformation
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; } = string.Empty;
        public string Nickname { get; set; } = string.Empty;
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Address is required")]
        public Address? Address { get; set; }

        [Required(ErrorMessage = "City is required")]
        public City? City { get; set; }

        [Required(ErrorMessage = "Country is required")]
        public Country? Country { get; set; }

        [Required(ErrorMessage = "Additional information is required")]
        public string AdditionalInfo { get; set; } = string.Empty;

        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public Gender? Gender { get; set; }

        [Required(ErrorMessage = "Nationality is required")]
        public Nationality? Nationality { get; set; }

        [Required(ErrorMessage = "Occupation is required")]
        public Occupation? Occupation { get; set; }

        [Required(ErrorMessage = "Preferred Language is required")]
        public Language? Language { get; set; }

        [Required(ErrorMessage = "Education Level is required")]
        public EducationLevel? EducationLevel { get; set; }

        [Required(ErrorMessage = "Employment Status is required")]
        public EmploymentStatus? EmploymentStatus { get; set; }

        [Required(ErrorMessage = "Years of Experience is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Years of Experience must be a positive number")]
        public int YearsOfExperience { get; set; }

        public List<Skill> Skills { get; set; } = new List<Skill>();
        public List<PreviousEmployment> PreviousEmployments { get; set; } = new List<PreviousEmployment>();

        // Other client information properties
    }
}
