using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService.Models
{
    public class Notification
    {
        public Guid NotificationId { get; set; }
        public string Recipient { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public Notification(string recipient, string message, string status)
        {
            NotificationId = Guid.NewGuid();
            Recipient = recipient;
            Message = message;
            Status = status;
        }

    }
}
