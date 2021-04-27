using AlulaShop.Domain.Contract.Common;
using AlulaShop.Domain.Contract.Repositories;
using AlulaShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlulaShop.Infrascture.DataBase.EF.Repositories
{
    public class CategoryChildRepository : BaseRepository<CategoryChild, long>, ICategoryChildRepository
    {
        public CategoryChildRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
