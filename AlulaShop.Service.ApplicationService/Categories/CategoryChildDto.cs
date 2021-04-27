using AlulaShop.Service.ApplicationService.Common;
using AlulaShop.Service.ApplicationService.Products;

namespace AlulaShop.Service.ApplicationService.Categories
{
    /// <summary>
    /// <see cref="long"/>
    /// </summary>
    public class CategoryChildDto : EntityDto<long>
    {
        public ProductDto Product { get; set; }
        public CategoryDto Category { get; set; }
    }
}