using AlulaShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlulaShop.Domain.Contract.Common
{
    public interface IUnitOfWork
    {

        void Commit();

        DbSet<TEntity> Set<TEntity>() where TEntity : class;


    }
}
