using UA.Models;

namespace UA.Services.AccountServices
{
    public interface IAccountService
    {
        Task<AccountModel> Authenticate(AccountModel model);
    }
}
