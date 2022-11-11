using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ADMail.Mail
{
    public class MailServerAppService : CrudAppService<MailServer, MailServerDto, Guid, MailServerPagedAndSortedResultRequestDto, CreateUpdateMailServerDto>, IMailServerAppService
    {
        private readonly IMailServerRepository _mailServerRepository;
        public MailServerAppService(IMailServerRepository repository) : base(repository)
        {
            _mailServerRepository = repository;
        }

        public override async Task<PagedResultDto<MailServerDto>> GetListAsync(MailServerPagedAndSortedResultRequestDto input)
        {
            var filter = ObjectMapper.Map<MailServerPagedAndSortedResultRequestDto, MailServerFilter>(input);

            var sorting = (string.IsNullOrEmpty(input.Sorting) ? "Name DESC" : input.Sorting).Replace("ShortName", "Name");

            var mailServers = await _mailServerRepository.GetListAsync(input.SkipCount, input.MaxResultCount, sorting, filter);
            var totalCount = await _mailServerRepository.GetTotalCountAsync(filter);

            return new PagedResultDto<MailServerDto>(totalCount, ObjectMapper.Map<List<MailServer>, List<MailServerDto>>(mailServers));
        }
    }
}