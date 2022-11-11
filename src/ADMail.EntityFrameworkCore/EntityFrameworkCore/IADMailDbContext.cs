using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ADMail.EntityFrameworkCore;

[ConnectionStringName(ADMailDbProperties.ConnectionStringName)]
public interface IADMailDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
