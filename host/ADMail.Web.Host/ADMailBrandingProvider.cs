using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ADMail;

[Dependency(ReplaceServices = true)]
public class ADMailBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ADMail";
}
