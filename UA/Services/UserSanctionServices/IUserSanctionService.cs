using UA.Models;

namespace UA.Services.UserSanctionServices
{
    public interface IUserSanctionService
    {
        Task<List<UserSanctionModel>> ListOfUserSanction(FilterParameter param);
        Task<UserSanctionModel> AddUserSanction(UserSanctionModel model);
        Task<UserSanctionModel> UpdateUserSanction(UserSanctionModel model);
        Task<UserSanctionModel> DeleteUserSanction(int id);
    }
}