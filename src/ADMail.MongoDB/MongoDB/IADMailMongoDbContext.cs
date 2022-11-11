using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace ADMail.MongoDB;

[ConnectionStringName(ADMailDbProperties.ConnectionStringName)]
public interface IADMailMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
