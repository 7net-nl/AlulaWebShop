using System;
using System.Collections.Generic;
using System.Text;

namespace AlulaShop.Service.ApplicationService.Common
{
    /// <summary>
    /// </summary>
    /// <typeparam name="TPrimaryKey"></typeparam>
    public class EntityDto<TPrimaryKey> where TPrimaryKey : struct
    {
        public TPrimaryKey ID { get; set; }
    }
}
