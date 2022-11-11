using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ADMail.EntityFrameworkCore;

public static class ADMailDbContextModelCreatingExtensions
{
    public static void ConfigureADMail(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        /* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(ADMailDbProperties.DbTablePrefix + "Questions", ADMailDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */
        builder.Entity<MailServer>(b =>
        {
            b.ToTable(ADMailDbProperties.DbTablePrefix + "MailServer", ADMailDbProperties.DbSchema);
            b.ConfigureByConvention();
        });
    }
}
