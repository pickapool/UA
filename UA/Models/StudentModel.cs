
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UA.Models
{

    public class StudentModel
    {
        [Required(ErrorMessage = "Student No. is required.")] 
        public string IdNo { get; set; } = string.Empty;
        public int StudentId {  get; set; }
        [Required(ErrorMessage = "Student name is required.")] 
        public string StudentName { get; set; } = string.Empty;
        public int CourseId { get; set; }
        public int DepartmentId { get; set; }
        public int SectionId { get; set; }
        public CourseModel Course { get; set; } = new();
        public DepartmentModel Department { get; set; } = new();
        public SectionModel Section { get; set; } = new();
        public List<UserSanctionModel> Sanctions { get; set;} = new();
        public Enums.Enums.YearLevel YearLevel { get; set; }

    }
}
