using AlulaShop.Domain.Contract.Common;
using AlulaShop.Domain.Contract.Repositories;
using AlulaShop.Domain.Entities;
using AlulaShop.Service.ApplicationService.Common;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlulaShop.Service.ApplicationService.Categories
{
    /// <summary>
    /// <see cref="long"/>
    /// </summary>
    public class CategoryService : BaseService<Category, CategoryDto, long>,ICategoryService
    {
        public CategoryService(IBaseRepository<Category, long> repository, IUnitOfWork unitOfWork, IMapper mapper) : base(repository, unitOfWork, mapper)
        {
        }

        public override List<CategoryDto> GetAll()
        {
            var Test = repository.GetAll();
            return base.GetAll();
        }
    }
}
