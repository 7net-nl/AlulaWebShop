using System;
using System.Collections.Generic;
using System.Text;

namespace AlulaShop.Domain.Entities
{
    /// <summary>
    /// <see cref="long"/>
    /// </summary>
    public class Review : Entity<long>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public byte Rank { get; set; }
        public string Description { get; set; }
        public Product Product { get; set; }

    }
}
