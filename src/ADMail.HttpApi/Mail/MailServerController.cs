using ADMail.Samples;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace ADMail.Mail
{
    [Area(ADMailRemoteServiceConsts.ModuleName)]
    [RemoteService(Name = ADMailRemoteServiceConsts.RemoteServiceName)]
    [Route("api/ADMail/MailServer")]
    public class MailServerController : ADMailController, IMailServerAppService
    {
        private readonly IMailServerAppService _mailServerAppService;
        public MailServerController(IMailServerAppService mailServerAppService)
        {
            _mailServerAppService = mailServerAppService;
        }

        [HttpPost]
        [Authorize]
        public Task<MailServerDto> CreateAsync(CreateUpdateMailServerDto input)
        {
            return _mailServerAppService.CreateAsync(input);
        }
        [HttpDelete]
        public Task DeleteAsync(Guid id)
        {
            return _mailServerAppService.DeleteAsync(id);
        }
        [HttpGet("{id}")]
        public Task<MailServerDto> GetAsync(Guid id)
        {
            return (_mailServerAppService.GetAsync(id));
        }
        [HttpGet()]
        public Task<PagedResultDto<MailServerDto>> GetListAsync(MailServerPagedAndSortedResultRequestDto input)
        {
            return _mailServerAppService.GetListAsync(input);
        }
        [HttpPut]
        public Task<MailServerDto> UpdateAsync(Guid id, CreateUpdateMailServerDto input)
        {
            return _mailServerAppService.UpdateAsync(id, input);
        }
    }
}
