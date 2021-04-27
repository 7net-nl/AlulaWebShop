using AlulaShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlulaShop.Infrascture.DataBase.EF.Configuration
{
    public class ReviewConfig : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.Property(c => c.Description).HasMaxLength(1000).IsRequired();
            builder.Property(c => c.Email).HasMaxLength(1000).IsRequired();
            builder.Property(c => c.Name).HasMaxLength(300).IsRequired();
            builder.Property(c => c.Rank).HasMaxLength(1).IsRequired();
        }
    }
}
