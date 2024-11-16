using NotificationService.Interfaces;
using NotificationService.Models;
using System.Net;
using System.Net.Mail;
namespace NotificationService.Providers
{
    public class EmailNotificationService: INotificationService
    {
        private readonly string _smtpServer;
        private readonly int _smtpPort;
        private readonly string _smtpUsername;
        private readonly string _smtpPassword;
        private readonly string _fromEmail;
        public EmailNotificationService(string smtpServer, int smtpPort, string smtpUsername, string smtpPassword, string fromEmail)
        {
            _smtpServer = smtpServer;
            _smtpPort = smtpPort;
            _smtpUsername = smtpUsername;
            _smtpPassword = smtpPassword;
            _fromEmail = fromEmail;
        }
        public async Task<List<Notification>> SendAsync(string recipient, string message)
        {

            try
            {
                await Task.Delay(100);
                return new List<Notification> { new Notification(recipient, message, "Email Sent") };
            }
            catch (Exception ex)
            {
                return new List<Notification> { new Notification(recipient, message, $"Error: {ex.Message}") };
            }

        }
    }
}
