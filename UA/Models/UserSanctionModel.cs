using UA.Models;

namespace UA.Models
{
    public class UserSanctionModel
    {
        public int UserSanctionId { get; set; }
        public int StudentId { get; set; }
        public int SanctionId { get; set; }
        public DateTime DateRecorded { get; set; }
        public SanctionModel Sanction { get; set; } = new();
        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }
        public byte[] SanctionImage { get; set; } = new byte[] { };
        public int UserId { get; set; }
        public AccountModel Account { get; set; } = new();
        public int? MarkAsPaidById { get; set; }
        public AccountModel MarkAsPaidByAccount { get; set; } = new();
        public string ImageBase64
        {
            get
            {
                return $"data:image/png;base64, {Convert.ToBase64String(SanctionImage)}";
            }
        }
    }
}