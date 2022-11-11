using Volo.Abp.Modularity;

namespace ADMail;

[DependsOn(
    typeof(ADMailApplicationModule),
    typeof(ADMailDomainTestModule)
    )]
public class ADMailApplicationTestModule : AbpModule
{

}
