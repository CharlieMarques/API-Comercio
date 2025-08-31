using Microsoft.EntityFrameworkCore;
using API_Comercio.Models.Domain;

namespace API_Comercio.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opcions) : base(opcions) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
