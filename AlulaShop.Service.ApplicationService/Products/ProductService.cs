using AlulaShop.Domain.Contract.Common;
using AlulaShop.Domain.Contract.Repositories;
using AlulaShop.Domain.Entities;
using AlulaShop.Service.ApplicationService.Common;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlulaShop.Service.ApplicationService.Products
{
    public class ProductService : BaseService<Product, ProductDto, long>,IProductService
    {
        public ProductService(IBaseRepository<Product, long> repository, IUnitOfWork unitOfWork, IMapper mapper) : base(repository, unitOfWork, mapper)
        {
        }
    }
}
