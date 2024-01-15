namespace Accessories_Store.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<ProductCategory>? ProructCategories { get; set; }

    }
}
