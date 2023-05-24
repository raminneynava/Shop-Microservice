using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using Products.Domain.Categories;
using Products.Domain.Products;

namespace Products.Infrastructure.Context
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options):base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Order is important. Because first we have insert into Category and then use categoryId when inserting Product
            modelBuilder.ApplyConfiguration(new Category.CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new Product.ProductConfiguration());
        }
    }
}
