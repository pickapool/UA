namespace UA.Models
{
    public class EventModel
    {
        public int EventId { get; set; }
        public string EventName { get; set; } = string.Empty;
        public DateTime? DateOfEvent { get; set; }
    }
}
