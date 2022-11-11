using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace ADMail;

[DependsOn(
    typeof(ADMailApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class ADMailHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(ADMailApplicationContractsModule).Assembly,
            ADMailRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ADMailHttpApiClientModule>();
        });

    }
}
