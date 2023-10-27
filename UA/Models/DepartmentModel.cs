
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UA.Models
{

    public class DepartmentModel
    {
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Department name is required.")] 
        public string DepartmentName { get; set; } = string.Empty;
        public List<DepartmentCourseModel> Courses { get; set; } = new();
        public int C { get; set; }
    }
}
