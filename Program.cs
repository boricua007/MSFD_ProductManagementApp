using MSFD_ProductManagementApp.Models;
using MSFD_ProductManagementApp.Data;


using(var context = new ApplicationDbContext())
{
    context.Database.EnsureCreated();

    // CREATE: Add a new product
    var newProduct = new Product(1, "Laptop", 999.99m, 100);
    context.Products.Add(newProduct);
    context.SaveChanges();

    // READ: Retrieve and display all products
    var products = context.Products.ToList();
    foreach (var product in products)
    {
        Console.WriteLine($"Product: ID: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.StockQuantity}");
    }   

    // UPDATE: Update the price of th first product
    var productToUpdate = context.Products.First();
    productToUpdate.Price = 899.99m;
    context.SaveChanges();

    // DELETE: Remove the  product
    var productToDelete = context.Products.OrderByDescending(p => p.Id).Last();
    context.Products.Remove(productToDelete);
    context.SaveChanges();
}


