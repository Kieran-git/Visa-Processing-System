using AFS_Visa_Processing_System.Models;

namespace AFS_Visa_Processing_System.Services
{
    public interface IVisaApplicationData
    {
        bool CreateVisaApplication();
        VisaApplication GetVisaApplicationByID(int VisaApplicationID);
    }
}