using AlulaShop.Domain.Entities;
using AlulaShop.Service.ApplicationService.Common;

namespace AlulaShop.Service.ApplicationService.Categories
{
    public interface ICategoryService : IBaseService<Category,CategoryDto,long>
    {
    }
}