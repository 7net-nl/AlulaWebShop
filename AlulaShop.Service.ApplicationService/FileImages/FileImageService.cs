using AlulaShop.Domain.Contract.Common;
using AlulaShop.Domain.Contract.Repositories;
using AlulaShop.Domain.Entities;
using AlulaShop.Service.ApplicationService.Common;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlulaShop.Service.ApplicationService.FileImages
{
    public class FileImageService : BaseService<FileImage, FileImageDto, long>, IFileImageService
    {
        public FileImageService(IBaseRepository<FileImage, long> repository, IUnitOfWork unitOfWork, IMapper mapper) : base(repository, unitOfWork, mapper)
        {
        }
    }
}
