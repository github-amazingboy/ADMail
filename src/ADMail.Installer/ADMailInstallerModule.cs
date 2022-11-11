using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace ADMail;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class ADMailInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ADMailInstallerModule>();
        });
    }
}
