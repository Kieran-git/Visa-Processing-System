using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AFS_Visa_Processing_System.Models
{
    public class VisaApplication
    {
        [Key] public int VisaApplicationID { get; set; } // Primary Key
        [ForeignKey("User")] public virtual User User { get; set; } // Foreign key linking to user
        [Required] public string FullLegalName { get; set; }
        [Required] public string EmailAddress { get; set; }
        [Required] public long? ContactNumber { get; set; }
        [Required] public DateTime DateOfBirth { get; set; }
        [Required] public VisaType? VisaType { get; set; }
        [Required] public string PurposeOfStay { get; set; }
        [Required] public string CountryOfOrigin { get; set; }
        [Required] public string CountryOfDestination { get; set; }
        [Required] public byte[] Identification { get; set; }
        [Required] public byte[] ProofOfAddress { get; set; }

        [SetsRequiredMembers]
        public VisaApplication()
        {
            User = new User();
            FullLegalName = string.Empty;
            EmailAddress = string.Empty;
            DateOfBirth = DateTime.Today.AddYears(-18);
            PurposeOfStay = string.Empty;
            CountryOfOrigin = string.Empty;
            CountryOfDestination = string.Empty;
            Identification = Array.Empty<byte>();
            ProofOfAddress = Array.Empty<byte>();
        }
    }
}