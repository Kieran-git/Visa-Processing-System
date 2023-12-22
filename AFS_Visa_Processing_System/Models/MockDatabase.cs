using AFS_Visa_Processing_System.Pages;
using Newtonsoft.Json;
using System.Net.Sockets;

namespace AFS_Visa_Processing_System.Models
{
    public static class MockDatabase
    {
        public static bool WriteToVisaApplication(VisaApplication visaApplication)
        {
            try
            {
                // This will only work on the server side of the blazor app so for this client only app it is mocked
                // File.AppendAllText(Path.Combine(dataDirectory, "VisaApplicationTable.txt"), JsonConvert.SerializeObject(visaApplication) + Environment.NewLine);
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
                // This will only work on the server side of the blazor app so for this client only app it is mocked
                // File.AppendAllText(Path.Combine(dataDirectory, "Logs.txt"), JsonConvert.SerializeObject(@event) + Environment.NewLine);
            }
            catch
            {
                throw;
            }
            return true;
        }
    }
}
