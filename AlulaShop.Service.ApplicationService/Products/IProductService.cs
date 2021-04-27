using AlulaShop.Domain.Entities;
using AlulaShop.Service.ApplicationService.Common;

namespace AlulaShop.Service.ApplicationService.Products
{
    public interface IProductService : IBaseService<Product,ProductDto,long>
    {
    }
}