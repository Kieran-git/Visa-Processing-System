using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AFS_Visa_Processing_System.Models;

namespace AFS_Visa_Processing_System.Data
{
    public class AFS_Visa_Processing_SystemContext : DbContext
    {
        public AFS_Visa_Processing_SystemContext (DbContextOptions<AFS_Visa_Processing_SystemContext> options)
            : base(options)
        {
        }

        public DbSet<AFS_Visa_Processing_System.Models.VisaApplication> VisaApplication { get; set; } = default!;
    }
}
