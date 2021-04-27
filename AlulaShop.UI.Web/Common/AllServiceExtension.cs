using AlulaShop.Domain.Contract.Common;
using AlulaShop.Domain.Contract.Repositories;
using AlulaShop.Domain.Entities;
using AlulaShop.Infrascture.DataBase.EF.Common;
using AlulaShop.Infrascture.DataBase.EF.Repositories;
using AlulaShop.Service.ApplicationService.Brands;
using AlulaShop.Service.ApplicationService.Categories;
using AlulaShop.Service.ApplicationService.Common;
using AlulaShop.Service.ApplicationService.FileImages;
using AlulaShop.Service.ApplicationService.Products;
using AlulaShop.Service.ApplicationService.Reviews;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlulaShop.UI.Web.Common
{
    public static class AllServiceExtension
    {
        public static void AddAllService(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IBaseRepository<,>), typeof(BaseRepository<,>));
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICategoryChildRepository, CategoryChildRepository>();
            services.AddScoped<IFileImageRepository, FileImageRepository>();
            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<IReviewRepository, ReviewRepository>();


            services.AddScoped(typeof(IBaseService<,,>), typeof(BaseService<,,>));
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryChildService, CategoryChildService>();
            services.AddScoped<IFileImageService, FileImageService>();
            services.AddScoped<IBrandService, BrandService>();
            services.AddScoped<IReviewService, ReviewService>();
            
            
        }
    }
}
