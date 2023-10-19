
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UA.Models
{
    public class CourseModel
    {
        
        public int CourseId { get; set; }
        [Required(ErrorMessage = "Course name is required.")] 
        public string CourseName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Shortcut name is required.")] 
        public string ShortcutName { get; set; } = string.Empty;
    }
}
