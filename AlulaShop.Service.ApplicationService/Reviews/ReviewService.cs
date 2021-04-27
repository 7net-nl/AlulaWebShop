using AlulaShop.Domain.Contract.Common;
using AlulaShop.Domain.Contract.Repositories;
using AlulaShop.Domain.Entities;
using AlulaShop.Service.ApplicationService.Common;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlulaShop.Service.ApplicationService.Reviews
{
    public class ReviewService : BaseService<Review, ReviewDto, long> , IReviewService
    {
        public ReviewService(IBaseRepository<Review, long> repository, IUnitOfWork unitOfWork, IMapper mapper) : base(repository, unitOfWork, mapper)
        {
        }
    }
}
