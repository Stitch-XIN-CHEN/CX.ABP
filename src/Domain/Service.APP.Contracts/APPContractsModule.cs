using Volo.Abp.Application;
using Volo.Abp.Modularity;

namespace Service.APP.Contracts
{
    [DependsOn(typeof(AbpDddApplicationContractsModule))]
    public class APPContractsModule : AbpModule
    {
    }
}
