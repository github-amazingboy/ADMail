using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using ADMail.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Design;
namespace ADMail
{
    public class MailServerRepository : EfCoreRepository<ADMailDbContext, MailServer, Guid>, IMailServerRepository
    {
        private readonly IDbContextProvider<ADMailDbContext> _dbContextProvider;

        public MailServerRepository(IDbContextProvider<ADMailDbContext> dbContextProvider) : base(dbContextProvider)
        {
            this._dbContextProvider = dbContextProvider;
        }

        public async Task<List<MailServer>> GetListAsync(int skipCount, int maxResultCount, string sorting = "Name", MailServerFilter filter = null)
        {
            var dbSet = await GetDbSetAsync();
            var books = await dbSet
                .WhereIf(!filter.Name.IsNullOrWhiteSpace(), x => x.Name.Contains(filter.Name))
                .OrderBy(sorting)
                .Skip(skipCount)
                .Take(maxResultCount)
                .ToListAsync();
            return books;
        }

        public async Task<int> GetTotalCountAsync(MailServerFilter filter)
        {
            var dbSet = await GetDbSetAsync();
            var books = await dbSet
                .WhereIf(!filter.Name.IsNullOrWhiteSpace(), x => x.Name.Contains(filter.Name))
                .ToListAsync();
            return books.Count;
        }

    }
}