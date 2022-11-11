using ADMail.Localization;
using Volo.Abp.AspNetCore.Components;

namespace ADMail.Blazor.Server.Host;

public abstract class ADMailComponentBase : AbpComponentBase
{
    protected ADMailComponentBase()
    {
        LocalizationResource = typeof(ADMailResource);
    }
}
