using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace ADMail
{
    public class MailServerPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public string Name { get; set; }
    }
}