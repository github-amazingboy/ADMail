using ADMail.Localization;
using Volo.Abp.Application.Services;

namespace ADMail;

public abstract class ADMailAppService : ApplicationService
{
    protected ADMailAppService()
    {
        LocalizationResource = typeof(ADMailResource);
        ObjectMapperContext = typeof(ADMailApplicationModule);
    }
}
