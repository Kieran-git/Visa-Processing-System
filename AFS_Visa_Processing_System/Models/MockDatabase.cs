using AFS_Visa_Processing_System.Pages;
using Newtonsoft.Json;

namespace AFS_Visa_Processing_System.Models
{
    public static class MockDatabase
    {
        private static readonly string dataDirectory = @"C:\Users\Kieran\source\repos\SAD-Assessment-Visa-Processing-System\AFS_Visa_Processing_System\Data\";
        public static bool WriteToVisaApplication(VisaApplication visaApplication)
        {
            try
            {
                File.AppendAllText(Path.Combine(dataDirectory, "VisaApplicationTable.txt"), JsonConvert.SerializeObject(visaApplication) + Environment.NewLine);
            }
            catch
            {
                throw;
            }
            return true;
        }
        public static VisaApplication ReadFromVisaApplication(int visaApplicationID)
        {
            // Not implemented for the scope of this proof of concept
            return new VisaApplication();
        }
        public static bool WriteToLogs(Event @event)
        {
            try
            {
                File.AppendAllText(Path.Combine(dataDirectory, "Logs.txt"), JsonConvert.SerializeObject(@event) + Environment.NewLine);
            }
            catch
            {
                throw;
            }
            return true;
        }
    }
}
