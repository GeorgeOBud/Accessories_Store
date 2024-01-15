using Accessories_Store.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Accessories_Store.Pages
{
    public class ProductSearchModel : PageModel
    {
        public ProductData ProductD { get; set; }
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string CurrentFilter { get; set; }
        public void OnGet(int? id, int? categoryID, string searchString)
        {
            CurrentFilter = searchString;

            if (!String.IsNullOrEmpty(searchString))
            {
                ProductD.Products = ProductD.Products
                    .Where(s => s.Name.Contains(searchString) || s.Brand.Contains(searchString));
            }
                if (id != null)
                {
                    ProductID = id.Value;
                    Product product = ProductD.Products
                    .Where(i => i.ID == id.Value).Single();
                    ProductD.Categories = product.ProductCategories.Select(s => s.Category);
                }
        }
    }
}
