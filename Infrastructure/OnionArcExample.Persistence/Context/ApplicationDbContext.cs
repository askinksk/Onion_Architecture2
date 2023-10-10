using Microsoft.EntityFrameworkCore;
using OnionArcExample.Application.Interfaces.Context;
using OnionArcExample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArcExample.Persistence.Context
{
    public class ApplicationDbContext : DbContext, IApplicationContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        { }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 120, ProductName = "Product 1", QuantityPerUnit = "Product 1 Description", UnitPrice = 1000, UnitsInStock = 10 },
                new Product { ProductId = 121, ProductName = "Product 2", QuantityPerUnit = "Product 2 Description", UnitPrice = 2000, UnitsInStock = 20 },
                new Product { ProductId = 122, ProductName = "Product 3", QuantityPerUnit = "Product 3 Description", UnitPrice = 3000, UnitsInStock = 30 },
                new Product { ProductId = 123, ProductName = "Product 4", QuantityPerUnit = "Product 4 Description", UnitPrice = 4000, UnitsInStock = 40 }
                );
        }
    }
}
