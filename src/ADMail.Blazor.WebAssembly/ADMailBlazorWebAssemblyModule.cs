using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace ADMail.Blazor.WebAssembly;

[DependsOn(
    typeof(ADMailBlazorModule),
    typeof(ADMailHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class ADMailBlazorWebAssemblyModule : AbpModule
{

}
