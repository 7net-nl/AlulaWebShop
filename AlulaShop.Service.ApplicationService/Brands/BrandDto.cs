using AlulaShop.Service.ApplicationService.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlulaShop.Service.ApplicationService.Brands
{
    /// <summary>
    /// <see cref="long"/>
    /// </summary>
    public class BrandDto : EntityDto<long>
    {
        public string Name { get; set; }
    }
}
