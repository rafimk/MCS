namespace MCS.NotificationServices
{
    public class NotificationPayload
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public Severity Severity { get; set; }
        public IList<string> Recipients { get; set; }
    }
}