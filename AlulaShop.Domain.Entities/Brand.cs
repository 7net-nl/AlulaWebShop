using System;
using System.Collections.Generic;
using System.Text;

namespace AlulaShop.Domain.Entities
{
    /// <summary>
    /// <see cref="long"/>
    /// </summary>
    public class Brand : Entity<long>
    {
        public string Name { get; set; }
    }
}
