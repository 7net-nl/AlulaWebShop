using AlulaShop.Service.ApplicationService.Common;
using AlulaShop.Service.ApplicationService.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlulaShop.Service.ApplicationService.Reviews
{
    /// <summary>
    /// <see cref="long"/>
    /// </summary>
    public class ReviewDto : EntityDto<long>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public byte Rank { get; set; }
        public string Description { get; set; }
        public ProductDto Product { get; set; }
    }
}
