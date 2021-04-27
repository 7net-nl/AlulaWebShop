using System;
using System.Collections.Generic;
using System.Text;

namespace AlulaShop.Domain.Entities
{
    /// <summary>
    /// <see cref="long"/>
    /// </summary>
    public class Product : Entity<long>
    {

        public List<Category> Categories { get; set; }
        public string Title { get; set; }
        public List<Review> Reviews { get; set; }
        public byte Ranks { get; set; }
        public decimal NewPrice { get; set; }
        public decimal OldPrice { get; set; }
        public decimal WithoutTax { get; set; }
        public Brand Brand { get; set; }
        public string Code { get; set; }
        public EnumAvailable Available { get; set; }
        public string Description { get; set; }
        public List<FileImage> Images { get; set; }


    }
}
