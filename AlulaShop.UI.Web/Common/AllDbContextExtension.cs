using AlulaShop.Infrascture.DataBase.EF.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlulaShop.UI.Web.Common
{
    public static class AllDbContextExtension
    {
        public static void AddAllDbContext(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<EFDbContext>(c => c.UseSqlServer(configuration.GetConnectionString("EfDb")));
        }
    }
}
