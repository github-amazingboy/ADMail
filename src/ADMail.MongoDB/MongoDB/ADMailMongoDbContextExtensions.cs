using Volo.Abp;
using Volo.Abp.MongoDB;

namespace ADMail.MongoDB;

public static class ADMailMongoDbContextExtensions
{
    public static void ConfigureADMail(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
