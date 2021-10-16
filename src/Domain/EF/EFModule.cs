using Domain.Entity;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.SqlServer;
using Volo.Abp.Modularity;

namespace EF
{
    [DependsOn(
        typeof(AbpEntityFrameworkCoreModule),
        typeof(AbpEntityFrameworkCoreSqlServerModule))]
    public class EFModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<TestContext>(x =>
            {
                x.AddDefaultRepositories(true); //所有默认的聚合根 配置一个默认的仓储
            }
            ); //
            Configure<AbpDbContextOptions>(x =>
            {
                x.UseSqlServer(); //注入EF
            }
            );
        }
    }
}
