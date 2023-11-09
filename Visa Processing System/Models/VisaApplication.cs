using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Visa_Processing_System.Models
{
    public class VisaApplication
    {
        public int ID { get; set; }
        public int VisaTypeID { get; set; }
        public int UserID { get; set; }
        public List<string> documentation { get; set; } // File paths

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