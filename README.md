# Notification Service Library

## Overview

The **Notification Service Library** provides an extensible system for sending various types of notifications (such as **Email**, **Push**, **SMS**, **Slack**, and more). The library is designed to be used in any .NET-based application, with a focus on providing a simple, clean, and extendable interface for integrating multiple notification services.

## Features

- **Email Notifications**: Send email notifications using SMTP.
- **Push Notifications**: Send push notifications to users.
- **SMS Notifications**: Integrate with SMS gateways (you can implement additional SMS services).
- **Slack Notifications**: Send notifications to Slack channels (future extension).
- **Extensibility**: Add new notification providers by implementing the `INotificationService` interface.
- **Async Operations**: All notification operations are asynchronous.

## Getting Started

### Installation

To use this Notification Service in your project:

1. **Add the Notification Service Class Library** to your project.
   - Download the compiled class library (DLL) or add it as a project reference in your solution.

2. **Install Dependencies (if any)**:
   - For **Email** notifications, make sure you have access to an SMTP server (e.g., Gmail, SendGrid, etc.).
   - For **Push**, **SMS**, or **Slack**, you might need to implement the corresponding services or SDKs.

### Usage

Here’s an example of how to use the library in a console application.

#### 1. **Setting up the Services**

You can configure your notification services (Email, SMS, etc.) like this:

```csharp
using NotificationServiceLibrary;
using NotificationServiceLibrary.Models;
using NotificationServiceLibrary.Services;

class Program
{
    static async Task Main(string[] args)
    {
        // Create the services
        INotificationService emailService = new EmailNotificationService();
        INotificationService pushService = new PushNotificationService();
        INotificationService smsService = new SmsNotificationService();

        // Use the Notification Decorator to combine services
        INotificationService notificationService = new NotificationDecorator(emailService, pushService, smsService);

        // Send a notification
        List<Notification> notifications = await notificationService.SendAsync("recipient@example.com", "This is a test message");

        // Print out the notifications
        foreach (var notification in notifications)
        {
            Console.WriteLine($"NotificationId: {notification.NotificationId}, Recipient: {notification.Recipient}, Status: {notification.Status}, Message: {notification.Message}");
        }
    }
}
