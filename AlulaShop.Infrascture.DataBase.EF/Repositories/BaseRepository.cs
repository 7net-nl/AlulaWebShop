using AlulaShop.Domain.Contract.Common;
using AlulaShop.Domain.Contract.Repositories;
using AlulaShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlulaShop.Infrascture.DataBase.EF.Repositories
{
    public class BaseRepository<TEntity,TPrimaryKey> : IBaseRepository<TEntity,TPrimaryKey> where TEntity : Entity<TPrimaryKey>
        where TPrimaryKey : struct
    {
        private readonly IUnitOfWork unitOfWork;

        public BaseRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public void Add(TEntity entity)
        {
            unitOfWork.Set<TEntity>().Add(entity);
        }

        public void Update(TEntity entity)
        {
            unitOfWork.Set<TEntity>().Update(entity);
        }

        public void Delete(TEntity entity)
        {
            unitOfWork.Set<TEntity>().Remove(entity);
        }

        public TEntity Find(TPrimaryKey key)
        {
            return unitOfWork.Set<TEntity>().Find(key);
        }

        public IQueryable<TEntity> GetAll()
        {
            
            return unitOfWork.Set<TEntity>();
        }
    }
}
