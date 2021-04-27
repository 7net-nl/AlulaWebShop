using AlulaShop.Domain.Entities;
using AlulaShop.Service.ApplicationService.Brands;
using AlulaShop.Service.ApplicationService.Categories;
using AlulaShop.Service.ApplicationService.Common;
using AlulaShop.Service.ApplicationService.FileImages;
using AlulaShop.Service.ApplicationService.Reviews;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlulaShop.Service.ApplicationService.Products
{
    /// <summary>
    /// <see cref="long"/>
    /// </summary>
    public class ProductDto : EntityDto<long>
    {
        public List<CategoryDto> Categories { get; set; }
        public string Title { get; set; }
        public List<ReviewDto> Reviews { get; set; }
        public byte Ranks { get; set; }
        public decimal NewPrice { get; set; }
        public decimal OldPrice { get; set; }
        public decimal WithoutTax { get; set; }
        public BrandDto Brand { get; set; }
        public string Code { get; set; }
        public EnumAvailable Available { get; set; }
        public string Description { get; set; }
        public List<FileImageDto> Images { get; set; }
    }
}
