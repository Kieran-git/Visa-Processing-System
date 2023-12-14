using System.ComponentModel.DataAnnotations;

namespace AFS_Visa_Processing_System.Models
{
    public class VisaApplication
    {
        public int VisaApplicationID { get; set; }
        public int UserID { get; set; }
        [Required]
        public string FullLegalName { get; set; } = string.Empty;
        [Required]
        public string EmailAddress { get; set; } = string.Empty;
        [Required]
        public int ContactNumber { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public VisaType? VisaType { get; set; }
        [Required]
        public string PurposeOfStay { get; set; } = string.Empty;
        [Required]
        public string CountryOfOrigin { get; set; } = string.Empty;
        [Required]
        public string CountryOfDestination { get; set; } = string.Empty;
        [Required]
        public byte[]? Identification { get; set; }
        [Required]
        public byte[]? ProofOfAddress { get; set; }
    }
}