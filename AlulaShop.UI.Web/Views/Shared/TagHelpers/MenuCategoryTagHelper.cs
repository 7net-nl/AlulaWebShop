using AlulaShop.Domain.Contract.Repositories;
using AlulaShop.Service.ApplicationService.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlulaShop.UI.Web.Views.Shared.TagHelpers
{
	[HtmlTargetElement("li",Attributes ="asp-Action")]
	public class MenuCategoryTagHelper : TagHelper
	{
        private readonly IUrlHelperFactory urlHelperFactory;
        private readonly ICategoryService categoryService;

        public MenuCategoryTagHelper(IUrlHelperFactory urlHelperFactory,ICategoryService categoryService)
		{
            this.urlHelperFactory = urlHelperFactory;
            this.categoryService = categoryService;
        }
		[ViewContext]
        [HtmlAttributeNotBound]
		public ViewContext ViewContext { get; set; }
        [HtmlAttributeName("asp-Action")]
        public string Action { get; set; }
        [HtmlAttributeName("asp-Controller")]
        public string Controller { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
		{
			var RouteCurrent = urlHelperFactory.GetUrlHelper(ViewContext);
            output.Content.AppendHtml($@"<li>");
            foreach (var Category in categoryService.GetAll().Distinct().ToList())
            {
                output.Content.AppendHtml($@"<a href='{RouteCurrent.Action(Action,Controller,new { Category.Name })}'>{Category.Name}</a>");
                output.Content.AppendHtml($@"<ul>");
                foreach (var CategoryChild in Category.Categories.ToList())
                {
                    output.Content.AppendHtml($@"<li><a href='{RouteCurrent.Action(Action,Controller,new {CategoryChild = "" })}'>Test</a></li>");
                }
                
            }
            output.Content.AppendHtml($@"</li>");

        }
	}
}
