using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Accessories_Store.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Brand { get; set; }
        public string? Color { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Quantity { get; set; }
        public int? VendorID { get; set; }
        public Vendor? Vendor { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal OldPrice { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        public ICollection<ProductCategory>? ProductCategories { get; set; }

    }
}
