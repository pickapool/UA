using System.ComponentModel.DataAnnotations;

namespace UA.Models
{
    public class DepartmentCourseModel
    {
        public int DepartmentCourseId { get; set; }
        public int DepartmentId { get; set; }
        public int CourseId { get; set; }
        public CourseModel Course { get; set; } = new();
        public DepartmentModel Department { get; set; } = new();
    }
}