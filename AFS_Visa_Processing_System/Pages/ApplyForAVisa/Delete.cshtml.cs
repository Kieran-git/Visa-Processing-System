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
    public class DeleteModel : PageModel
    {
        private readonly AFS_Visa_Processing_System.Data.AFS_Visa_Processing_SystemContext _context;

        public DeleteModel(AFS_Visa_Processing_System.Data.AFS_Visa_Processing_SystemContext context)
        {
            _context = context;
        }

        [BindProperty]
      public VisaApplication VisaApplication { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.VisaApplication == null)
            {
                return NotFound();
            }

            var visaapplication = await _context.VisaApplication.FirstOrDefaultAsync(m => m.VisaAppID == id);

            if (visaapplication == null)
            {
                return NotFound();
            }
            else 
            {
                VisaApplication = visaapplication;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.VisaApplication == null)
            {
                return NotFound();
            }
            var visaapplication = await _context.VisaApplication.FindAsync(id);

            if (visaapplication != null)
            {
                VisaApplication = visaapplication;
                _context.VisaApplication.Remove(VisaApplication);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
