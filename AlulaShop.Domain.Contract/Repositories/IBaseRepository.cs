using AlulaShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlulaShop.Domain.Contract.Repositories
{
    public interface IBaseRepository<TEntity,TPrimaryKey> where TEntity : Entity<TPrimaryKey>
        where TPrimaryKey : struct
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity Find(TPrimaryKey key);
        IQueryable<TEntity> GetAll();
    }
}
