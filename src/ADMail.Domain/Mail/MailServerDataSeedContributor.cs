using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace ADMail.Mail
{
    public class MailServerDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        public IRepository<MailServer,Guid> repository { get; set; }
        public MailServerDataSeedContributor(IRepository<MailServer, Guid> repository)
        {
            this.repository = repository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if(await this.repository.GetCountAsync() > 0) {
                return;
            }
            await this.repository.InsertManyAsync(new List<MailServer>
            {
                new MailServer{ Name="xxxyyy", SMTPServerAddress="xxxyyy.com",Port=25},
                new MailServer{ Name="666788", SMTPServerAddress="666788.com",Port=25},
            }, autoSave: true);
        }
    }
}
