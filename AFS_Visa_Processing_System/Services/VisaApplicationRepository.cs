using AFS_Visa_Processing_System.Models;

namespace AFS_Visa_Processing_System.Services
{
    public class VisaApplicationRepository : IVisaApplicationRepository
    {
        public bool CreateVisaApplication(VisaApplication visaApplication)
        {
            return false;
        }

        public VisaApplication GetVisaApplicationByID(int VisaApplicationID)
        {
            // Not implemented dummy data
            return new VisaApplication();
        }

        public bool SaveToCache() 
        {
            return false;     
        }
    }
}