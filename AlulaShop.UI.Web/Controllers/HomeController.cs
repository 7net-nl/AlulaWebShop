using AlulaShop.Domain.Entities;
using AlulaShop.Service.ApplicationService.Brands;
using AlulaShop.Service.ApplicationService.Categories;
using AlulaShop.Service.ApplicationService.FileImages;
using AlulaShop.Service.ApplicationService.Products;
using AlulaShop.Service.ApplicationService.Reviews;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AlulaShop.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService productService;
        private readonly IMapper mapper;

        public HomeController(IProductService productService,IMapper mapper)
        {
            this.productService = productService;
            this.mapper = mapper;
        }
         public IActionResult Index()
        {
            var Result = productService.GetAll();
            
            return View(Result);
        }

        public IActionResult Product(string Category ,string CategoryChild)
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
