using AlulaShop.Domain.Entities;
using AlulaShop.Service.ApplicationService.Common;

namespace AlulaShop.Service.ApplicationService.Reviews
{
    public interface IReviewService : IBaseService<Review,ReviewDto,long>
    {
    }
}