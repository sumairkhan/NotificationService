using NotificationService.Interfaces;
using NotificationService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService.Providers
{
    public class SmsNotificationService : INotificationService
    {
        public async Task<List<Notification>> SendAsync(string recipient, string message)
        {
            await Task.Delay(100); 

            var notification = new Notification(recipient, message, "SMS Sent");
            return new List<Notification> { notification };
        }
    }
}
