namespace MCS.NotificationServices
{
    public interface INotificationService
    {
         public Task SendNotificationAsync(NotificationPayload message);
         public Task<IEnumerable<NotificationPayload>> GetNotificationsAsync();
    }
}