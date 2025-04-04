using TrinhHongQuyen_2122110059.Model;
using Microsoft.EntityFrameworkCore;

namespace TrinhHongQuyen_2122110059.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
