using AlulaShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlulaShop.Domain.Contract.Common
{
    public interface IDataSet
    {
        DbSet<Brand> Brands { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<CategoryChild>  CategoryChilds { get; set; }
        DbSet<FileImage> Images { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Review> Reviews { get; set; }
    }
}
