using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Senparc.CO2NET;
using SJTech.Core.Models;

namespace SJTech.Core
{
    public static class SenparcEntitiesExtension
    {
        public static IServiceCollection AddSenparcEntitiesDI(this IServiceCollection services)
        {

            //var connectionString = SJTech.Core.Config.SenparcDatabaseConfigs.ClientConnectionString;
            //services.AddDbContext<SenparcEntities>(options => options.UseSqlServer(connectionString, b => b.MigrationsAssembly("Senparc.Web")));

            services.AddScoped(s => new SenparcEntities(new DbContextOptionsBuilder<SenparcEntities>()
                .UseSqlServer(Config.SenparcDatabaseConfigs.ClientConnectionString)
                .Options));
            //#if DEBUG
            //            var connectionString = SJTech.Core.Config.SenparcDatabaseConfigs.ClientConnectionString;
            //            services.AddDbContext<SenparcEntities>(options => options.UseSqlServer(connectionString, b => b.MigrationsAssembly("Senparc.Web")));
            //#else
            //            services.AddScoped(s => new SenparcEntities(new DbContextOptionsBuilder<SenparcEntities>()
            //                .UseSqlServer(Config.SenparcDatabaseConfigs.ClientConnectionString)
            //                .Options));
            //#endif

            SenparcDI.GlobalIServiceProvider = null;//清空缓存，下次使用DI会自动重新Build

            return services;
        }
    }
}
