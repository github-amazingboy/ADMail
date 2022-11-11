using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace ADMail.Mail
{
    public class MailServerDto : EntityDto<Guid>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string SMTPServerAddress { get; set; }

        public int Port { get; set; }

        public bool EnableSSL { get; set; }

        public string SenderEmail { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string SenderNameInEmail { get; set; }
    }
}