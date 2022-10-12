using System.Text;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace MCS.NotificationServices
{
    public class NotificationService : INotificationService
    {
        private readonly HttpClient _httpClient;
        private readonly IOptions<NotificationServiceOptions> _options;
        public NotificationService(HttpClient httpClient, IOptions<NotificationServiceOptions> options)
        {
            _httpClient = httpClient;
            _options = options;
        }

        public Task<IEnumerable<NotificationPayload>> GetNotificationsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task SendNotificationAsync(string message)
        {
            var jsonData = JsonConvert.SerializeObject(message);
            var request = new HttpRequestMessage(HttpMethod.Post, _options.Value.NotificationServiceUrl);
            request.Content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
        }

        public Task SendNotificationAsync(NotificationPayload message)
        {
            throw new NotImplementedException();
        }
    }
}