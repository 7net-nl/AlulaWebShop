using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlulaShop.UI.Web.Views.Shared.Components.BrandLogoSlider
{
    [ViewComponent(Name ="BrandLogoSlider")]
    public class BrandLogoSliderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
