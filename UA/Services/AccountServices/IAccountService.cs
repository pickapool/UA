using UA.Models;

namespace UA.Services.AccountServices
{
    public interface IAccountService
    {
        Task<AccountModel> Authenticate(AccountModel model);
        Task<AccountModel> UpdatePassword(int id, AccountModel model);
        Task<List<AccountModel>> ListOfUsers(FilterParameter param);
        Task<AccountModel> AddUser(AccountModel model);
        Task<AccountModel> Remove(int id);
    }
}
