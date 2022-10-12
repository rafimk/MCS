namespace MCS.NotificationServices
{
    public class NotificationDto
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public Severity Severity { get; set; }
        public DateTime Date { get; set;}
        public Status Status { get; set; }
    }
}