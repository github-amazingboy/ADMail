using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace ADMail;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(ADMailDomainSharedModule)
)]
public class ADMailDomainModule : AbpModule
{

}
