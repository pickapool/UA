
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
        [Required(ErrorMessage = "QR CODE is required.")] 
        public string QRCode { get; set; } = string.Empty;
        public CourseModel Course { get; set; } = new();
        public DepartmentModel Department { get; set; } = new();
        public SectionModel Section { get; set; } = new();
        public List<UserSanctionModel> Sanctions { get; set;} = new();
        public Enums.Enums.YearLevel YearLevel { get; set; }
        public string FacialRecognitionId { get; set; } = string.Empty;
        public bool IsTableLoading { get; set; }

        //For report
        public bool IsOpenSanctions { get; set; }
        public string Departmentname { get; set; } = string.Empty;
        public string CourseName { get; set; } = string.Empty;
        public string SectionName { get; set; } = string.Empty;
        public string SanctionName { get; set; } = string.Empty;
        public decimal SanctionAmount { get; set; }
        public bool IsPaid { get; set; }
        public DateTime DateRecorded { get; set; }

    }
}
