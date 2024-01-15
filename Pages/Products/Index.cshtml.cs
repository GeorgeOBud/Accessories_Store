using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Accessories_Store.Data;
using Accessories_Store.Models;

namespace Accessories_Store.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly Accessories_Store.Data.Accessories_StoreContext _context;

        public IndexModel(Accessories_Store.Data.Accessories_StoreContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Product != null)
            {
                Product = await _context.Product
                    .Include(b => b.Vendor)
                    .ToListAsync();
            }
        }
    }
}
