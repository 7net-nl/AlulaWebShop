using AlulaShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlulaShop.Domain.Contract.Repositories
{
    public interface IProductRepository : IBaseRepository<Product,long>
    {
    }
}
