using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AFS_Visa_Processing_System.Models
{
    public class VisaApplication
    {
        [Key]
        public int VisaAppID { get; set; }
        public int VisaTypeID { get; set; }
        public int UserID { get; set; }

        //List<File> documentation;

        bool GetApplicationInProgress()
        {
            return false;
        }
        bool SaveToCache()
        {
            return false;
        }
        bool CreateVisaApplicationRecord()
        {
            return false;
        }
    }
}
