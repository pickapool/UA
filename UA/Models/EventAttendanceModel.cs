
namespace UA.Models
{
    public class EventAttendanceModel
    {
        public int EventAttendanceId { get; set; }
        public int EventId { get; set; }
        public int StudentId { get; set; }
        public string FacialRecognitionId { get; set; }
        public StudentModel Student { get; set; }
    }
}
