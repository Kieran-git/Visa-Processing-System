using System.ComponentModel.DataAnnotations;

namespace AFS_Visa_Processing_System.Models
{
    public class User
    {
        [Key] public int UserID { get; set; }
        [Required] public string? Role { get; set; }

        public User()
        {
            Role = "Applicant";
        }

    }
}
