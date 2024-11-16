using NotificationService.Interfaces;
using NotificationService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService.Providers
{
    public class PushNotificationService : INotificationService
    {
        public async Task<List<Notification>> SendAsync(string recipient, string message)
        {
            try
            {
                await Task.Delay(100);
                var notification = new Notification(recipient, message, "Push Notification Sent");
                return new List<Notification> { notification };
            }
            catch (Exception ex)
            {
                return new List<Notification> { new Notification(recipient, message, $"Error: {ex.Message}") };
            }
        }
    }
}
