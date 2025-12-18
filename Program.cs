using MSFD_ProductManagementApp.Models;
using MSFD_ProductManagementApp.Data;


using(var context = new ApplicationDbContext())
{
    context.Database.EnsureCreated();

    // CREATE: Add a new product
    var newProduct = new Product("Laptop", 999.99m, 100);
    context.Products.Add(newProduct);
    context.SaveChanges();

    // READ: Retrieve and display all products
    Console.WriteLine("=== PRODUCT MANAGEMENT SYSTEM ===");

    var products = context.Products.ToList();
    Console.WriteLine($"Total products in database: {products.Count}");
    
    foreach (var product in products)
    {
        Console.WriteLine($"Product: ID: {product.Id}, Name: {product.Name}, Price: ${product.Price}, Stock: {product.StockQuantity}");
    }   

    // UPDATE: Update the price of the first product
    var productToUpdate = context.Products.First();
    Console.WriteLine($"\nUpdating product {productToUpdate.Id} price from ${productToUpdate.Price} to $899.99");
    productToUpdate.Price = 899.99m;
    context.SaveChanges();

    // DELETE: Remove the product
    var productToDelete = context.Products.OrderByDescending(p => p.Id).Last();
    Console.WriteLine($"Deleting product: {productToDelete.Name} (ID: {productToDelete.Id})");
    context.Products.Remove(productToDelete);
    context.SaveChanges();
    
    Console.WriteLine("\n=== FINAL DATABASE STATE ===");
    var finalProducts = context.Products.ToList();
    Console.WriteLine($"Remaining products: {finalProducts.Count}");
    foreach (var product in finalProducts)
    {
        Console.WriteLine($"Product: ID: {product.Id}, Name: {product.Name}, Price: ${product.Price}, Stock: {product.StockQuantity}");
    }
    
    Console.WriteLine("\nPress any key to exit...");
    Console.ReadKey();
}


