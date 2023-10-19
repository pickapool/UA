
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UA.Models
{

    public class SectionModel
    {
        public int SectionId { get; set; }
        [Required(ErrorMessage = "Section is required.")] 
        public string SectionName { get; set; } = string.Empty;
    }
}
