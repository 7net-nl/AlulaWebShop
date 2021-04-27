using AlulaShop.Domain.Contract.Common;
using AlulaShop.Domain.Entities;
using AlulaShop.Infrascture.DataBase.EF.Configuration;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlulaShop.Infrascture.DataBase.EF.Common
{
    public class EFDbContext : DbContext,IDataSet
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryChild> CategoryChilds { get; set; }
        public DbSet<FileImage> Images { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public EFDbContext(DbContextOptions<EFDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BrandConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new FileImageConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new ReviewConfig());

            modelBuilder.Seed();
        }

    }
}
