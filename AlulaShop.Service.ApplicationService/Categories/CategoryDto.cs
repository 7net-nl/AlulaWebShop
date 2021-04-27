using AlulaShop.Domain.Entities;
using AlulaShop.Service.ApplicationService.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlulaShop.Service.ApplicationService.Categories
{
    /// <summary>
    /// <see cref="long"/>
    /// </summary>
    public class CategoryDto : EntityDto<long>
    {
        public string Name { get; set; }
        public List<CategoryChildDto> Categories { get; set; }
    }
}
