
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UA.Models
{

    public class SanctionModel
    {
        public int SanctionId { get; set; }
        public int UserId { get; set; }
        [Required(ErrorMessage = "Sanction is required.")] 
        public string SanctionName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Amount is required.")]
        public decimal Amount { get; set; }
    }
}
