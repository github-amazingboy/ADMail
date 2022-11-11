using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
namespace ADMail
{
    public class MailServer : FullAuditedEntity<Guid>
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
