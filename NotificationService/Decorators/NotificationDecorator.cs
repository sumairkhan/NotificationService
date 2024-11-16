using NotificationService.Interfaces;
using NotificationService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService.Decorators
{
    public class NotificationDecorator : INotificationService
    {
        private readonly List<INotificationService> _notificationServices;

        public NotificationDecorator(params INotificationService[] notificationServices)
        {
            _notificationServices = new List<INotificationService>(notificationServices);
        }

        public async  Task<List<Notification>> SendAsync(string recipient, string message)
        {
            var notifications = new List<Notification>();
            foreach (var service in _notificationServices)
            {
                var result = await service.SendAsync(recipient, message);
                notifications.AddRange(result); 
            }
            return notifications;
        }
    }
}
