using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AFS_Visa_Processing_System.Data;
using AFS_Visa_Processing_System.Models;

namespace AFS_Visa_Processing_System.Pages.ApplyForAVisa
{
    public class IndexModel : PageModel
    {
        private readonly AFS_Visa_Processing_System.Data.AFS_Visa_Processing_SystemContext _context;

        public IndexModel(AFS_Visa_Processing_System.Data.AFS_Visa_Processing_SystemContext context)
        {
            _context = context;
        }

        public IList<VisaApplication> VisaApplication { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.VisaApplication != null)
            {
                VisaApplication = await _context.VisaApplication.ToListAsync();
            }
        }
    }
}
