using ADMail.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ADMail;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(ADMailEntityFrameworkCoreTestModule)
    )]
public class ADMailDomainTestModule : AbpModule
{

}
