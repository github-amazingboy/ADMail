using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace ADMail.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(ADMailBlazorModule)
    )]
public class ADMailBlazorServerModule : AbpModule
{

}
