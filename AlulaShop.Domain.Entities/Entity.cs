using System;

namespace AlulaShop.Domain.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TPrimaryKey"></typeparam>
    
    public abstract class Entity<TPrimaryKey> where TPrimaryKey : struct
    {
        public TPrimaryKey ID { get; set; }
    }
}
