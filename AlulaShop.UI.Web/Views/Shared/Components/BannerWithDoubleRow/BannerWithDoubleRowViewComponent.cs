using AlulaShop.Service.ApplicationService.FileImages;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlulaShop.UI.Web.Views.Shared.Components.BannerWithDoubleRow
{
    [ViewComponent(Name = "BannerWithDoubleRow")]
    public class BannerWithDoubleRowViewComponent:ViewComponent
    {
        private readonly IFileImageService fileImage;

        public BannerWithDoubleRowViewComponent(IFileImageService fileImage)
        {
            this.fileImage = fileImage;
        }
        public IViewComponentResult Invoke(long ProductId)
        {
            var Images = fileImage.GetAll().FirstOrDefault();
            return View(Images);
        }
    }
}
