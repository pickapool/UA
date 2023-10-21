using UA.Models;
using System.Net.Http.Json;

namespace UA.Services.UserSanctionServices
{
    public class UserSanctionService : IUserSanctionService
    {
        private readonly IConfiguration configuration;
        HttpClient client;
        List<UserSanctionModel> list = new();
        UserSanctionModel model = new();
        public UserSanctionService(HttpClient _client, IConfiguration _config)
        {
            client = _client;
            configuration = _config;
        }
        public async Task<List<UserSanctionModel>> ListOfUserSanction(FilterParameter param)
        {

            HttpResponseMessage responseMessage = await client.PostAsJsonAsync("UserSanction/List", param);
            if (responseMessage.IsSuccessStatusCode)
            {
                list = await responseMessage.Content.ReadFromJsonAsync<List<UserSanctionModel>>();
            }
            return list?? new();
        }
        public async Task<UserSanctionModel> AddUserSanction(UserSanctionModel model)
        {
            HttpResponseMessage responseMessage = await client.PostAsJsonAsync("UserSanction/AddUserSanction", model);
            if (responseMessage.IsSuccessStatusCode)
            {
                model = await responseMessage.Content.ReadFromJsonAsync<UserSanctionModel>();
            }
            return model?? new();
        }
        public async Task<UserSanctionModel> UpdateUserSanction(UserSanctionModel model)
        {
            HttpResponseMessage responseMessage = await client.PutAsJsonAsync(String.Format("UserSanction/UpdateUserSanction/{0}", model.UserSanctionId), model);
            if (responseMessage.IsSuccessStatusCode)
            {
                model = await responseMessage.Content.ReadFromJsonAsync<UserSanctionModel>();
            }
            return model?? new();
        }
        public async Task<UserSanctionModel> DeleteUserSanction(int id)
        {
            HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("UserSanction/DeleteUserSanction/{0}",id));
            if (responseMessage.IsSuccessStatusCode)
            {
                model = await responseMessage.Content.ReadFromJsonAsync<UserSanctionModel>();
            }
            return model?? new();
        }
    }
}