using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace ILRXmlGenerator.Models
{
    public class UserDetails
    {
        [Required(ErrorMessage = "UKPRN is required")]
        public string UKPRN { get; set; }

        [Required(ErrorMessage = "ULN is required")]
        public string ULN { get; set; }
        public string AcademicYear { get; set; }

        [Required(ErrorMessage = "Family Name is required")]
        public string FamilyName {  get; set; }

        [Required(ErrorMessage = "Given Name is required")]
        public string GivenName { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Learn Start Date is required")]
        [DataType(DataType.Date)]
        public DateTime LearnStartDate { get; set; }

        [Required(ErrorMessage = "Learn Plan End Date is required")]
        [DataType(DataType.Date)]
        public DateTime LearnPlanEndDate { get; set; }

        [Required(ErrorMessage = "Standard Code is required")]
        public string StdCode { get; set; }

        [Required(ErrorMessage = "TNP1 is required")]
        public int TNP1 { get; set; }
        [Required(ErrorMessage = "TNP2 is required")]
        public int TNP2 { get; set; }
        public string CompletionStatus { get; set; }
        public string Outcome { get; set; }
        public DateTime? LearnActEndDate { get; set; }
    }
}
