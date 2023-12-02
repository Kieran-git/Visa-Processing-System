namespace AFS_Visa_Processing_System.Models
{
    public class VisaApplicationBL
    {
        private IVisaApplicationDAL visaApplicationDAL;

        public VisaApplicationBL(IVisaApplicationDAL visaApplicationDAL)
        {
            this.visaApplicationDAL = visaApplicationDAL;
        }

        public VisaApplication GetVisaApplication(int visaApplicationID)
        {
            return visaApplicationDAL.SelectVisaApplication(visaApplicationID);
        }

    }
}