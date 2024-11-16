using NotificationService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService.Interfaces
{
    public interface INotificationService
    {
        Task<List<Notification>> SendAsync(
                    string recipient,
                    string message);
    }
}
