using ADMail.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ADMail.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ADMailPageModel : AbpPageModel
{
    protected ADMailPageModel()
    {
        LocalizationResourceType = typeof(ADMailResource);
        ObjectMapperContext = typeof(ADMailWebModule);
    }
}
