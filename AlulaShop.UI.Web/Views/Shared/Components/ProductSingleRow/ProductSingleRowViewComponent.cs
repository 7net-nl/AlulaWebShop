using AlulaShop.Service.ApplicationService.FileImages;
using AlulaShop.Service.ApplicationService.Products;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlulaShop.UI.Web.Views.Shared.Components.ProductSingleRow
{
    [ViewComponent(Name ="ProductSingleRow")]
    public class ProductSingleRowViewComponent : ViewComponent
    {
        private readonly IFileImageService imageService;

        public ProductSingleRowViewComponent(IFileImageService imageService)
        {
            this.imageService = imageService;
        }
        public IViewComponentResult Invoke(long ProductId)
        {
            var Images = imageService.GetAll().Where(c=>c.ID == ProductId).LastOrDefault();


            return View(Images);
        }
    }
}
