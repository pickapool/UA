namespace UA.Models
{
    public class EventModel
    {
        public int EventId { get; set; }
        public string EventName { get; set; } = string.Empty;
        public DateTime? DateOfEvent { get; set; }
        public bool ShowAttendance { get; set; }
        public List<EventAttendanceModel> ListAttendance { get; set; } = new();
         public List<StudentModel> ListAbsent { get; set; } = new();
    }
}
