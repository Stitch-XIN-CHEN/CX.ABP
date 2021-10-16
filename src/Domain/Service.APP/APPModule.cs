using Domain;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Service.APP
{
    [DependsOn(
        typeof(DomainModule),
        typeof(AbpAutoMapperModule)
        // typeof(APPContractsModule)
        )]
    public class APPModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<APPModule>(); //全局映射profile
            });
        }
    }
}
