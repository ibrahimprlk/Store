using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories.EFCore
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, ProductName = "Computer", Price = 25000 },
                new Product() { Id = 2, ProductName = "Keyboard", Price = 200 },
                new Product() { Id = 3, ProductName = "Mouse", Price = 100 },
                new Product() { Id = 4, ProductName = "Monitor", Price = 5000 },
                new Product() { Id = 5, ProductName = "Deck", Price = 500 }
                );
            modelBuilder.Entity<Category>().HasData(
                    
                new Category() {Id=1,CategoryName="Book" },
                new Category() {Id=2,CategoryName="Electronic" }

                );
        }

    }
}
