using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace ADMail;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ADMailHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class ADMailConsoleApiClientModule : AbpModule
{

}
