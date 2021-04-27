using AlulaShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlulaShop.Infrascture.DataBase.EF.Configuration
{
    public class FileImageConfig : IEntityTypeConfiguration<FileImage>
    {
        public void Configure(EntityTypeBuilder<FileImage> builder)
        {
            builder.Property(c => c.FileName).HasMaxLength(1000).IsRequired();
           
        }
    }
}
