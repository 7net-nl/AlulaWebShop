using System.Collections.Generic;
using System.Linq;
using AlulaShop.Domain.Entities;

namespace AlulaShop.Service.ApplicationService.Common
{
    public interface IBaseService<TEntity, TEntityDto, TPrimaryKey>
        where TEntity : Entity<TPrimaryKey>
        where TEntityDto : EntityDto<TPrimaryKey>
        where TPrimaryKey : struct
    {
        void Delete(TPrimaryKey key);
        List<TEntity> DtoToEntity(List<TEntityDto> entityDto);
        TEntity DtoToEntity(TEntityDto entityDto);
        List<TEntityDto> EntityToDto(List<TEntity> entity);
        TEntityDto EntityToDto(TEntity entity);
        List<TEntityDto> GetAll();
        void Save(TEntityDto entityDto);
    }
}