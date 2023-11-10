using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AFS_Visa_Processing_System.Data;
using AFS_Visa_Processing_System.Models;

namespace AFS_Visa_Processing_System.Pages.ApplyForAVisa
{
    public class EditModel : PageModel
    {
        private readonly AFS_Visa_Processing_System.Data.AFS_Visa_Processing_SystemContext _context;

        public EditModel(AFS_Visa_Processing_System.Data.AFS_Visa_Processing_SystemContext context)
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

            var visaapplication =  await _context.VisaApplication.FirstOrDefaultAsync(m => m.VisaAppID == id);
            if (visaapplication == null)
            {
                return NotFound();
            }
            VisaApplication = visaapplication;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(VisaApplication).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VisaApplicationExists(VisaApplication.VisaAppID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool VisaApplicationExists(int id)
        {
          return (_context.VisaApplication?.Any(e => e.VisaAppID == id)).GetValueOrDefault();
        }
    }
}
