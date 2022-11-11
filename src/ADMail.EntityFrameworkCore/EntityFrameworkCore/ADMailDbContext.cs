using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ADMail.EntityFrameworkCore;

[ConnectionStringName(ADMailDbProperties.ConnectionStringName)]
public class ADMailDbContext : AbpDbContext<ADMailDbContext>, IADMailDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public ADMailDbContext(DbContextOptions<ADMailDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureADMail();
    }
}
