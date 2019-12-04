using Microsoft.EntityFrameworkCore;
using WebApp1.Data.Configuration;
using WebApp1.Models;
namespace WebApp1.Data {
    public class BakeryContext : DbContext {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite (@"Data source=WebApp1.db");
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration (new ProductConfiguration ()).seed();
        }
    }
}