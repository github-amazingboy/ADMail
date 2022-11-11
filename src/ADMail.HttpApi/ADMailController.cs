using ADMail.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ADMail;

public abstract class ADMailController : AbpControllerBase
{
    protected ADMailController()
    {
        LocalizationResource = typeof(ADMailResource);
    }
}
