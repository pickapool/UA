using UA.Models;

namespace UA.Models
{
    public class UserSanctionModel
    {
        public int UserSanctionId { get; set; }
        public int StudentId { get; set; }
        public int SanctionId { get; set; }
        public SanctionModel Sanction { get; set; } = new();
    }
}