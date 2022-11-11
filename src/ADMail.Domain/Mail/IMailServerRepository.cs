using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace ADMail;

public interface IMailServerRepository : IRepository<MailServer, Guid>
{
    Task<List<MailServer>> GetListAsync(int skipCount, int maxResultCount, string sorting = "Name", MailServerFilter filter = null);
    Task<int> GetTotalCountAsync(MailServerFilter filter);
}