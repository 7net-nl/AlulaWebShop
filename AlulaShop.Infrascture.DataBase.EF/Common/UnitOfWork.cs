using AlulaShop.Domain.Contract.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlulaShop.Infrascture.DataBase.EF.Common
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EFDbContext context;

        public UnitOfWork(EFDbContext context)
        {
            this.context = context;
        }
        public void Commit()
        {
            context.SaveChanges();
        }

        public DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return context.Set<TEntity>();
        }
    }
}
