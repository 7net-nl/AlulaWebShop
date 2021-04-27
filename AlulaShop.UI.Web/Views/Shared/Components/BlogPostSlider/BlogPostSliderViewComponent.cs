using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlulaShop.UI.Web.Views.Shared.Components.BlogPostSlider
{
    [ViewComponent(Name = "BlogPostSlider")]
    public class BlogPostSliderViewComponent : ViewComponent
    {
       
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
