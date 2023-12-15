using System.ComponentModel.DataAnnotations;

namespace AFS_Visa_Processing_System.Models
{
    public class VisaApplication
    {
        public int VisaApplicationID { get; set; }
        public int UserID { get; set; }
        public string FullLegalName { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public long ContactNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public VisaType? VisaType { get; set; }
        public string PurposeOfStay { get; set; } = string.Empty;
        public string CountryOfOrigin { get; set; } = string.Empty;
        public string CountryOfDestination { get; set; } = string.Empty;
        public byte[]? Identification { get; set; }
        public byte[]? ProofOfAddress { get; set; }
    }
}