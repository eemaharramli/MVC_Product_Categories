using Microsoft.EntityFrameworkCore;
using MVC_ProductsAndCategories_db.Models;

namespace MVC_ProductsAndCategories_db.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}