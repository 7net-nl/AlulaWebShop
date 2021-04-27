using AlulaShop.Service.ApplicationService.Categories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlulaShop.UI.Web.Views.Shared.Components.CategoryArea
{
    [ViewComponent(Name ="CategoryArea")]
    public class CategoryAreaViewComponent : ViewComponent
    {
        private readonly ICategoryService categoryService;

        public CategoryAreaViewComponent(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        public IViewComponentResult Invoke(CategoryDto categoryDto)
        {
            var Category = categoryService.GetAll().LastOrDefault();
            return View(Category);
        }
    }
}
