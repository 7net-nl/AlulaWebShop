using AlulaShop.Domain.Contract.Repositories;
using AlulaShop.Domain.Entities;
using AlulaShop.Infrascture.DataBase.EF.Common;
using AlulaShop.Infrascture.DataBase.EF.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlulaShop.UI.Web.Common
{
    public static class SeedHelperUIExtension
    {
        public static void SeeAddMigrationAuto(this IApplicationBuilder app)
        {
            using (var EfDbCtx = app.ApplicationServices.CreateScope().ServiceProvider.GetService<EFDbContext>())
            {
                
                EfDbCtx.Database.Migrate();
            }
        }
        public static void SeedAddProduct(this IApplicationBuilder app)
        {


            using (var EfDbCtx = app.ApplicationServices.CreateScope().ServiceProvider.GetService<EFDbContext>())
            {
                if (!EfDbCtx.Products.Any())
                {

                 AddProduct(EfDbCtx);

                }

                EfDbCtx.SaveChanges();
            }
        }

        private static void AddProduct(EFDbContext EfDbCtx)
        {
            EfDbCtx.Add(new Product
            {
                Available = EnumAvailable.Available,
                Brand = new Brand { Name = "Brac" },
                Categories = new List<Category> { new Category { Name = "Garden" }, new Category { Name = "Plant" } },
                Code = "abcd1234",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam fringilla augue nec est tristique auctor. Donec non est at libero vulputate rutrum. Morbi ornare lectus quis justo gravida semper. Nulla tellus mi, vulputate adipiscing cursus eu, suscipit id nulla." +
                   "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.",
                Images = new List<FileImage> { new FileImage { FileName = "small1-1.jpg" }, new FileImage { FileName = "small1-2.jpg" }, new FileImage { FileName = "small1-3.jpg" }, new FileImage { FileName = "small1-4.jpg" } },
                NewPrice = 100,
                OldPrice = 120,
                Ranks = 4,
                Title = "Lorem ipsum indoor plants",
                WithoutTax = 95,
                Reviews = new List<Review> { new Review { Description = "enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia res eos qui ratione voluptatem sequi Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci veli", Email = "fttcab@gmail.com", Name = "Cristopher Lee", Rank = 4 } }

            });
            EfDbCtx.Add(new Product
            {
                Available = EnumAvailable.Available,
                Brand = new Brand { Name = "Erab" },
                Categories = new List<Category> { new Category { Name = "Flower" }, new Category { Name = "Plant" } },
                Code = "abcd6321",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam fringilla augue nec est tristique auctor. Donec non est at libero vulputate rutrum. Morbi ornare lectus quis justo gravida semper. Nulla tellus mi, vulputate adipiscing cursus eu, suscipit id nulla." +
                   "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.",
                Images = new List<FileImage> { new FileImage { FileName = "small1-4.jpg" }, new FileImage { FileName = "small1-2.jpg" }, new FileImage { FileName = "small1-1.jpg" }, new FileImage { FileName = "small1-1.jpg" } },
                NewPrice = 85,
                OldPrice = 70,
                Ranks = 4,
                Title = "Lorem ipsum indoor plants",
                WithoutTax = 65,
                Reviews = new List<Review> { new Review { Description = "enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia res eos qui ratione voluptatem sequi Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci veli", Email = "fttcab@gmail.com", Name = "Cristopher Lee", Rank = 4 } }

            });
            EfDbCtx.Add(new Product
            {
                Available = EnumAvailable.Available,
                Brand = new Brand { Name = "Dora" },
                Categories = new List<Category> { new Category { Name = "Garden" } },
                Code = "bacd4356",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam fringilla augue nec est tristique auctor. Donec non est at libero vulputate rutrum. Morbi ornare lectus quis justo gravida semper. Nulla tellus mi, vulputate adipiscing cursus eu, suscipit id nulla." +
                   "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.",
                Images = new List<FileImage> { new FileImage { FileName = "small1-2.jpg" }, new FileImage { FileName = "small1-3.jpg" }, new FileImage { FileName = "small1-1.jpg" }, new FileImage { FileName = "small1-4.jpg" } },
                NewPrice = 170,
                OldPrice = 195,
                Ranks = 2,
                Title = "Lorem ipsum indoor plants",
                WithoutTax = 65,
                Reviews = new List<Review> { new Review { Description = "enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia res eos qui ratione voluptatem sequi Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci veli", Email = "fttcab@gmail.com", Name = "Cristopher Lee", Rank = 4 } }

            });
            EfDbCtx.Add(new Product
            {
                Available = EnumAvailable.Available,
                Brand = new Brand { Name = "Sera" },
                Categories = new List<Category> { new Category { Name = "Plant" } },
                Code = " abzt6521",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam fringilla augue nec est tristique auctor. Donec non est at libero vulputate rutrum. Morbi ornare lectus quis justo gravida semper. Nulla tellus mi, vulputate adipiscing cursus eu, suscipit id nulla." +
                   "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.",
                Images = new List<FileImage> { new FileImage { FileName = "small1-4.jpg" }, new FileImage { FileName = "small1-2.jpg" }, new FileImage { FileName = "small1-1.jpg" }, new FileImage { FileName = "small1-1.jpg" } },
                NewPrice = 210,
                OldPrice = 235,
                Ranks = 2,
                Title = "Lorem ipsum indoor plants",
                WithoutTax = 200,
                Reviews = new List<Review> { new Review { Description = "enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia res eos qui ratione voluptatem sequi Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci veli", Email = "fttcab@gmail.com", Name = "Cristopher Lee", Rank = 4 } }

            });
            EfDbCtx.Add(new Product
            {
                Available = EnumAvailable.Available,
                Brand = new Brand { Name = "Brac" },
                Categories = new List<Category> { new Category { Name = "Flower" }, new Category { Name = "Plant" } },
                Code = " tbcd4321",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam fringilla augue nec est tristique auctor. Donec non est at libero vulputate rutrum. Morbi ornare lectus quis justo gravida semper. Nulla tellus mi, vulputate adipiscing cursus eu, suscipit id nulla." +
                   "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.",
                Images = new List<FileImage> { new FileImage { FileName = "small1-1.jpg" }, new FileImage { FileName = "small1-2.jpg" }, new FileImage { FileName = "small1-3.jpg" }, new FileImage { FileName = "small1-4.jpg" } },
                NewPrice = 310,
                OldPrice = 350,
                Ranks = 5,
                Title = "Lorem ipsum indoor plants",
                WithoutTax = 320,
                Reviews = new List<Review> { new Review { Description = "enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia res eos qui ratione voluptatem sequi Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci veli", Email = "fttcab@gmail.com", Name = "Cristopher Lee", Rank = 4 } }

            });
            EfDbCtx.Add(new Product
            {
                Available = EnumAvailable.Available,
                Brand = new Brand { Name = "Brac" },
                Categories = new List<Category> { new Category { Name = "Flower" }, new Category { Name = "Plant" } },
                Code = " zbcd4321",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam fringilla augue nec est tristique auctor. Donec non est at libero vulputate rutrum. Morbi ornare lectus quis justo gravida semper. Nulla tellus mi, vulputate adipiscing cursus eu, suscipit id nulla." +
                  "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.",
                Images = new List<FileImage> { new FileImage { FileName = "small1-4.jpg" }, new FileImage { FileName = "small1-2.jpg" }, new FileImage { FileName = "small1-3.jpg" }, new FileImage { FileName = "small1-1.jpg" } },
                NewPrice = 310,
                OldPrice = 350,
                Ranks = 1,
                Title = "Lorem ipsum indoor plants",
                WithoutTax = 320,
                Reviews = new List<Review> { new Review { Description = "enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia res eos qui ratione voluptatem sequi Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci veli", Email = "fttcab@gmail.com", Name = "Cristopher Lee", Rank = 4 } }

            });
        }
    }
}
