using Localization.Resources.AbpUi;
using ADMail.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace ADMail;

[DependsOn(
    typeof(ADMailApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class ADMailHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(ADMailHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<ADMailResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
