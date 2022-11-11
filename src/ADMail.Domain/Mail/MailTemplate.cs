using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
namespace ADMail
{
    public class MailTemplate : FullAuditedEntity<Guid>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string SubjectContent { get; set; }

        [Required]
        public string BodyTemplateContent { get; set; }

        public string ReplyTo { get; set; }

    }
}
