using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Accessories_Store.Data;
using Accessories_Store.Models;

namespace Accessories_Store.Pages.Vendors
{
    public class DeleteModel : PageModel
    {
        private readonly Accessories_Store.Data.Accessories_StoreContext _context;

        public DeleteModel(Accessories_Store.Data.Accessories_StoreContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Vendor Vendor { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Vendor == null)
            {
                return NotFound();
            }

            var vendor = await _context.Vendor.FirstOrDefaultAsync(m => m.ID == id);

            if (vendor == null)
            {
                return NotFound();
            }
            else 
            {
                Vendor = vendor;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Vendor == null)
            {
                return NotFound();
            }
            var vendor = await _context.Vendor.FindAsync(id);

            if (vendor != null)
            {
                Vendor = vendor;
                _context.Vendor.Remove(Vendor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
