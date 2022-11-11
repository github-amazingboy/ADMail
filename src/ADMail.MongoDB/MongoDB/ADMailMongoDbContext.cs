using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace ADMail.MongoDB;

[ConnectionStringName(ADMailDbProperties.ConnectionStringName)]
public class ADMailMongoDbContext : AbpMongoDbContext, IADMailMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureADMail();
    }
}
