using AlulaShop.Domain.Contract.Common;
using AlulaShop.Domain.Contract.Repositories;
using AlulaShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlulaShop.Infrascture.DataBase.EF.Repositories
{
    public class CategoryRepository : BaseRepository<Category, long>, ICategoryRepository
    {
        public CategoryRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
