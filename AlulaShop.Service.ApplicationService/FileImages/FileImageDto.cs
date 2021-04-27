using AlulaShop.Domain.Entities;
using AlulaShop.Service.ApplicationService.Common;
using AlulaShop.Service.ApplicationService.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlulaShop.Service.ApplicationService.FileImages
{
    /// <summary>
    /// <see cref="long"/>
    /// </summary>
    public class FileImageDto : EntityDto<long>
    {
        public string FileName { get; set; }
        public ProductDto Product { get; set; }
    }
}
