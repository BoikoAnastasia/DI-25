namespace Di_25.Controllers
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Value { get; set; }

        public Product(int id, string name, decimal price, string description, int value)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
            Value = value;
        }

    }
}
