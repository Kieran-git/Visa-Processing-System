using AFS_Visa_Processing_System.Models;

namespace AFS_Visa_Processing_System.Services
{
    public class VisaApplicationData : IVisaApplicationData
    {
        public bool CreateVisaApplication()
        {
            return false;
        }

        public VisaApplication GetVisaApplicationByID(int VisaApplicationID)
        {
            // Not implemented dummy data
            return new VisaApplication();
        }
    }
}