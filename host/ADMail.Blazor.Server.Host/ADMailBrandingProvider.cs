using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ADMail.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class ADMailBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ADMail";
}
