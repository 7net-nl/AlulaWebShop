using AlulaShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlulaShop.Infrascture.DataBase.EF.Configuration
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(c => c.Available).IsRequired();
            builder.Property(c => c.Code).HasMaxLength(50).IsRequired();
            builder.Property(c => c.Description).HasMaxLength(4000).IsRequired();
            builder.Property(c => c.NewPrice).IsRequired();
            builder.Property(c => c.OldPrice).IsRequired();
            builder.Property(c => c.Ranks).HasMaxLength(1).IsRequired();
            builder.Property(c => c.Title).HasMaxLength(500).IsRequired();
            builder.Property(c => c.WithoutTax).IsRequired();

            builder.HasOne(c => c.Brand).WithMany().IsRequired();
            builder.HasMany<Category>(c => c.Categories).WithOne().IsRequired();
            builder.HasMany<Review>(c => c.Reviews).WithOne().IsRequired();
            builder.HasMany<FileImage>(c => c.Images).WithOne().IsRequired();
           
        }
    }
}
