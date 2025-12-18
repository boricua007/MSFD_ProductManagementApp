namespace MSFD_ProductManagementApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        
        // Constructor for new products (ID will be auto-generated)
        public Product(string name, decimal price, int stockQuantity)
        {
            Name = name;
            Price = price;
            StockQuantity = stockQuantity;
        }
        
        // Constructor for existing products (when loading from database)
        public Product(int id, string name, decimal price, int stockQuantity)
        {
            Id = id;
            Name = name;
            Price = price;
            StockQuantity = stockQuantity;
        }
    }
}