namespace AFS_Visa_Processing_System.Models
{
    public static class Logger
    {
        public static bool LogEvent(string title, string description)
        {
            // Log event to database
            return MockDatabase.WriteToLogs(new Event(title, description));
        }
    }
}
