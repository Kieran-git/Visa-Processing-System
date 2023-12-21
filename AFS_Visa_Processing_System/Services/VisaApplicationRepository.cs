using AFS_Visa_Processing_System.Models;

namespace AFS_Visa_Processing_System.Services
{
    public class VisaApplicationRepository : IVisaApplicationRepository
    {
        public bool CreateVisaApplication(VisaApplication visaApplication)
        {
            if (MockDatabase.WriteToVisaApplication(visaApplication))
            {
                Logger.LogEvent("New Visa Application",$"New Visa Application was succesfully created with ID: {visaApplication.VisaApplicationID}");
                return true;
            }
            else
                return false; 
        }

        public VisaApplication GetVisaApplicationByID(int VisaApplicationID)
        {
            return MockDatabase.ReadFromVisaApplication(VisaApplicationID);
        }
    }
}