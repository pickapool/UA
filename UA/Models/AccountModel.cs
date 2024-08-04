using System.ComponentModel.DataAnnotations.Schema;

namespace UA.Models
{
    public class AccountModel
    {
        public int UserId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public Enums.Enums.AccountType AccountType { get; set; }
    }
}
