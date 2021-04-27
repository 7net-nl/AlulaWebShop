using System;
using System.Collections.Generic;
using System.Text;

namespace AlulaShop.Domain.Entities
{
    /// <summary>
    /// <see cref="long"/>
    /// </summary>
    public class CategoryChild : Entity<long>
    {
        public Product Product { get; set; }
        public Category Category { get; set; }
    }
}
