using Volo.Abp.Application.Services;
using System;
using ADMail.Mail;
namespace ADMail
{
    public interface IMailServerAppService : ICrudAppService<MailServerDto, Guid, MailServerPagedAndSortedResultRequestDto, CreateUpdateMailServerDto>, IApplicationService
    {

    }
}