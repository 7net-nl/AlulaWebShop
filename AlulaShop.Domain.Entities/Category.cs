using System.Collections.Generic;

namespace AlulaShop.Domain.Entities
{
    /// <summary>
    /// <see cref="long"></see>
    /// </summary>
    public class Category : Entity<long>
    {
        public string Name { get; set; }
        public List<CategoryChild> Categories { get; set; }
    }
}