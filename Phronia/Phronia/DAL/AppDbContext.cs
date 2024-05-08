using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Phronia.Models;

namespace Phronia.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }
    }
}
