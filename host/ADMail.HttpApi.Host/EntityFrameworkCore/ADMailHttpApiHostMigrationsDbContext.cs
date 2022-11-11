using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace ADMail.EntityFrameworkCore;

public class ADMailHttpApiHostMigrationsDbContext : AbpDbContext<ADMailHttpApiHostMigrationsDbContext>
{
    public ADMailHttpApiHostMigrationsDbContext(DbContextOptions<ADMailHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureADMail();
    }
}
