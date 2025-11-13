using Microsoft.EntityFrameworkCore;

namespace StoreApp.Models
{
    public class RepositoryContext:DbContext
    {
        public RepositoryContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id=1,ProductName="Computer",Price=25000},
                new Product() { Id=2,ProductName="Keyboard",Price=200},
                new Product() { Id=3,ProductName="Mouse",Price=100},
                new Product() { Id=4,ProductName="Monitor",Price=5000},
                new Product() { Id=5,ProductName="Deck",Price=500}
                );
        }

    }
}
