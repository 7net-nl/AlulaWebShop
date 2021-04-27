using AlulaShop.Domain.Contract.Common;
using AlulaShop.Domain.Contract.Repositories;
using AlulaShop.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlulaShop.Service.ApplicationService.Common
{
    public class BaseService<TEntity, TEntityDto, TPrimaryKey> : IBaseService<TEntity, TEntityDto, TPrimaryKey> 
        where TEntity : Entity<TPrimaryKey>
        where TEntityDto : EntityDto<TPrimaryKey>
        where TPrimaryKey : struct

    {
        protected readonly IBaseRepository<TEntity, TPrimaryKey> repository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public BaseService(IBaseRepository<TEntity, TPrimaryKey> repository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public void Save(TEntityDto entityDto)
        {
            if (entityDto.ID.Equals(0))
            {
                repository.Add(DtoToEntity(entityDto));
                unitOfWork.Commit();
            }
            else
            {
                repository.Update(DtoToEntity(entityDto));
                unitOfWork.Commit();
            }
        }

        public void Delete(TPrimaryKey key)
        {
            if (!key.Equals(0))
            {
                var Entity = repository.Find(key);
                repository.Delete(Entity);
                unitOfWork.Commit();
            }
        }

        public virtual List<TEntityDto> GetAll()
        {
            return EntityToDto(repository.GetAll().ToList());
        }

        public TEntity DtoToEntity(TEntityDto entityDto)
        {
            return mapper.Map<TEntityDto, TEntity>(entityDto);
        }

        public TEntityDto EntityToDto(TEntity entity)
        {
            return mapper.Map<TEntity, TEntityDto>(entity);
        }

        public List<TEntity> DtoToEntity(List<TEntityDto> entityDto)
        {
            return mapper.Map<List<TEntityDto>, List<TEntity>>(entityDto);
        }

        public List<TEntityDto> EntityToDto(List<TEntity> entity)
        {
            return mapper.Map<List<TEntity>, List<TEntityDto>>(entity);
        }


    }
}
