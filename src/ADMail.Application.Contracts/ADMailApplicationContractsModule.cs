using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace ADMail;

[DependsOn(
    typeof(ADMailDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class ADMailApplicationContractsModule : AbpModule
{

}
