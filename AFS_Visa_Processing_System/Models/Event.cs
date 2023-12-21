using System.Diagnostics.CodeAnalysis;

namespace AFS_Visa_Processing_System.Models
{
    public class Event
    {
        public int EventID { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required DateTime TimeCreated {  get ; set; }

        [SetsRequiredMembers]
        public Event(string title, string description)
        {
            Title = title;
            Description = description;
            TimeCreated = DateTime.Now;
        }
    }
}
