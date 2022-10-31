
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApiProject.Models;

namespace TestApiProject.DBContext
{
    public class ProductDbContext : DbContext
    {

        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        { }

        public DbSet<ProductDetails> ProductDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductDetails>().HasData(
                new ProductDetails
                {
                   slNo = 101,
                   ProductName="Windows OS",
                   ProductDetail="Operating System",
                   Price=2000,
                   ProductType="Hardware"
                }
            );
        }
    }
}
