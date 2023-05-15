using System.ComponentModel.DataAnnotations;

namespace SayanJobeDone.Shared.Models
{
    public class PreviousEmployment
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Company name is required")]
        public string CompanyName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Job title is required")]
        public string JobTitle { get; set; } = string.Empty;

        [Required(ErrorMessage = "Start date is required")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End date is required")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

    }
}
