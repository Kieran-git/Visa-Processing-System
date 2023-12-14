using AFS_Visa_Processing_System.Models;

namespace AFS_Visa_Processing_System.Services
{
    public class VisaApplicationData : IVisaApplicationData
    {
        public bool CreateVisaApplication()
        {
            return true;
        }

        public VisaApplication GetVisaApplicationByID(int VisaApplicationID)
        {
            // Not implemented dummy data
            return new VisaApplication()
            {
                VisaApplicationID = 1,
                UserID = 1,
                Visa = new Visa()
                {
                    VisaID = 1,
                    VisaType = VisaType.Work
                },
                PurposeOfStay = "blah blah blah",
                CountryOfOrigin = "France",
                CountryOfDestination = "United Kingdom",
            };
        }
    }
}