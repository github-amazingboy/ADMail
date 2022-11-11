using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities.Auditing;

namespace ADMail
{
    public class GroupMailReceiver : FullAuditedEntity<Guid>
    {
        [Required]
        public string GroupName { get; set; }

        [Required]
        public string ReceiverEmails { get; set; }

        /// <summary>
        /// 抄送
        /// </summary>
        /// <value></value>
        public string CCEmails { get; set; }
    }
}