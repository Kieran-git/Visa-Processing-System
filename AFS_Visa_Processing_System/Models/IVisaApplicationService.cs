namespace AFS_Visa_Processing_System.Models
{
    public interface IVisaApplicationService
    {
        VisaApplication GetVisaApplicationByID(int VisaApplicationID);

        List<VisaApplication> GetAllVisaApplication();
    }
}