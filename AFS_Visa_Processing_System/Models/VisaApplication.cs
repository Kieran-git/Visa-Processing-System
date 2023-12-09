namespace AFS_Visa_Processing_System.Models
{
    public class VisaApplication
    {
        public int VisaApplicationID { get; set; }
        public int UserID { get; set; }
        public Visa? Visa { get; set; }
        public string Intentions { get; set; } = string.Empty;
        public string CountryOfOrigin { get; set; } = string.Empty;
        public string Destination { get; set; } = string.Empty;
        public List<string> Documentation { get; set; } = new List<string> {""};
    }
}