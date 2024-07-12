using System.ComponentModel.DataAnnotations;

namespace ILRXmlGenerator.Models
{
    public class UserDetails
    {
        [Required(ErrorMessage = "UKPRN is required")]
        public string UKPRN { get; set; }

        [Required(ErrorMessage = "ULN is required")]
        public string ULN { get; set; }

        [Required(ErrorMessage = "Academic Year is required")]
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
        public string TNP1 { get; set; }
        [Required(ErrorMessage = "TNP2 is required")]
        public string TNP2 { get; set; }
    }
}
