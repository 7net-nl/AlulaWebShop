using AlulaShop.Domain.Contract.Common;
using AlulaShop.Domain.Contract.Repositories;
using AlulaShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlulaShop.Infrascture.DataBase.EF.Repositories
{
    public class FileImageRepository : BaseRepository<FileImage, long>, IFileImageRepository
    {
        public FileImageRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
