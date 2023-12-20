using AFS_Visa_Processing_System.Models;

namespace AFS_Visa_Processing_System.Services
{
    public interface IVisaApplicationRepository
    {
        bool CreateVisaApplication(VisaApplication visaApplication);
        VisaApplication GetVisaApplicationByID(int VisaApplicationID);
        bool SaveToCache();
    }
}