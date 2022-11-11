using ADMail.Mail;
using AutoMapper;

namespace ADMail;

public class ADMailApplicationAutoMapperProfile : Profile
{
    public ADMailApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<MailServerPagedAndSortedResultRequestDto, MailServerFilter>();
        CreateMap<MailServer, MailServerDto>();
    }
}
