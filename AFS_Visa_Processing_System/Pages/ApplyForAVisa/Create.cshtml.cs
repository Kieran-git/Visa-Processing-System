using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AFS_Visa_Processing_System.Data;
using AFS_Visa_Processing_System.Models;

namespace AFS_Visa_Processing_System.Pages.ApplyForAVisa
{
    public class CreateModel : PageModel
    {
        private readonly AFS_Visa_Processing_System.Data.AFS_Visa_Processing_SystemContext _context;

        public CreateModel(AFS_Visa_Processing_System.Data.AFS_Visa_Processing_SystemContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public VisaApplication VisaApplication { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.VisaApplication == null || VisaApplication == null)
            {
                return Page();
            }

            _context.VisaApplication.Add(VisaApplication);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
