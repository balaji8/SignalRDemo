using Microsoft.AspNet.SignalR;

namespace SignalRDemo.Hubs
{
    public class NotificationHub : Hub
    {
        public void NotifyAll(string title, string message, string alertType)
        {
            Clients.All.displayNotification(title, message, alertType);
        }
    }
}