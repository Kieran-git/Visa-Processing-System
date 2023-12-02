namespace AFS_Visa_Processing_System.Models
{
    public interface IVisaApplicationDAL
    {
        VisaApplication SelectVisaApplication(int visaApplicationID);
    }

    public class VisaApplicationDAL : IVisaApplicationDAL
    {
        public VisaApplication SelectVisaApplication(int visaApplicationID)
        {
            var Visa = new Visa();

            // Get visa app from database, hardcoded for now
            var visaApplication = new VisaApplication() {
                VisaApplicationID = 1,
                UserID = 1,
                Visa = Visa,
                Intentions = "Blah blah blah",
                CountryOfOrigin = "France",
                Destination = "United Kingdom",
                Documentation = null
            };

            return visaApplication;
        }
    }
}