using Microsoft.EntityFrameworkCore;
using MSFD_ProductManagementApp.Models;

namespace MSFD_ProductManagementApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=np:\\.\pipe\LOCALDB#6E319E16\tsql\query;Database=ProductDB;Integrated Security=true;TrustServerCertificate=true",
                options => options.EnableRetryOnFailure(
                    maxRetryCount: 3,
                    maxRetryDelay: TimeSpan.FromSeconds(30),
                    errorNumbersToAdd: null));           
        }
    }
}