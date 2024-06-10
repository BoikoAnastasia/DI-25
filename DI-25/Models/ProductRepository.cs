namespace Di_25.Models
{
    public static class ProductRepository
    {
        private static List<Product> products = new List<Product>();

        static ProductRepository()
        {

            products.Add(new Product { Id = 1, Name = "Product 1", Cost = 10.0m, Description = "afdasf 1" });
            products.Add(new Product { Id = 2, Name = "Product 2", Cost = 20.0m, Description = "asfdsaf 2" });
            products.Add(new Product { Id = 3, Name = "Product 3", Cost = 30.0m, Description = "asdasd 3" });
        }

        public static List<Product> GetAllProducts()
        {
            return products;
        }
    }
}
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Cost { get; set; }
    public string Description { get; set; }
}
