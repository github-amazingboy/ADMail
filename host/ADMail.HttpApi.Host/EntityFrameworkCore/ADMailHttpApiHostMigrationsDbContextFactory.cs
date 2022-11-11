using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ADMail.EntityFrameworkCore;

public class ADMailHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<ADMailHttpApiHostMigrationsDbContext>
{
    public ADMailHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ADMailHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("ADMail"));

        return new ADMailHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
