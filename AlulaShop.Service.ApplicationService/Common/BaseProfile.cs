using AlulaShop.Domain.Entities;
using AlulaShop.Service.ApplicationService.Brands;
using AlulaShop.Service.ApplicationService.Categories;
using AlulaShop.Service.ApplicationService.FileImages;
using AlulaShop.Service.ApplicationService.Products;
using AlulaShop.Service.ApplicationService.Reviews;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlulaShop.Service.ApplicationService.Common
{
    public class BaseProfile : Profile
    {
        public BaseProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Brand, BrandDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<FileImage, FileImageDto>().ReverseMap();
            CreateMap<Review, ReviewDto>().ReverseMap();
        }
    }
}
