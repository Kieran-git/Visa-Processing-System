namespace AFS_Visa_Processing_System.Models
{
    public class VisaApplicationService : IVisaApplicationService
    {

        public List<VisaApplication> DataSource()
        {
            return new List<VisaApplication>()
            {
                new VisaApplication()
                {
                    VisaApplicationID = 1,
                    UserID = 1,
                    Visa = new Visa()
                    {
                        VisaID = 1,
                        VisaType = VisaType.Work
                    },
                    Intentions = "blah blah blah",
                    CountryOfOrigin = "France",
                    Destination = "United Kingdom",
                }
            };
        }

        public List<VisaApplication> GetAllVisaApplication()
        {
            return null;
        }

        public VisaApplication GetVisaApplicationByID(int VisaApplicationID)
        {
            return null;
        }
    }
}