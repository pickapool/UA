
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UA.Models
{

    public class StudentModel
    {
        public int StudentId {  get; set; }
        [Required(ErrorMessage = "Student name is required.")] 
        public string StudentName { get; set; } = string.Empty;
        public int CourseId { get; set; }
        public int DepartmentId { get; set; }
        public int SectionId { get; set; }
        public CourseModel Course { get; set; }
        public DepartmentModel Department { get; set; }
        public SectionModel Section { get; set; }
        public List<SanctionModel> Sanctions { get; set;}
        public Enums.Enums.YearLevel YearLevel { get; set; }

    }
}
