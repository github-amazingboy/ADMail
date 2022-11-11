using ADMail.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ADMail.Pages;

public abstract class ADMailPageModel : AbpPageModel
{
    protected ADMailPageModel()
    {
        LocalizationResourceType = typeof(ADMailResource);
    }
}
