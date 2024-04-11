using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Reflection;
using UA.Models;

namespace UA.Services.AccountServices
{
    public class AccountService :IAccountService
    {
        private readonly IConfiguration configuration;
        HttpClient client;
        public AccountService(HttpClient _client, IConfiguration _config)
        {
            client = _client;
            configuration = _config;
        }

        public async Task<AccountModel> AddUser(AccountModel model)
        {
           var account = new AccountModel();
            HttpResponseMessage responseMessage = await client.PostAsJsonAsync("users/AddUser", model);
            if (responseMessage.IsSuccessStatusCode)
            {
                account = await responseMessage.Content.ReadFromJsonAsync<AccountModel>();
            }
            return account ?? new();
        }

        public async Task<AccountModel> Authenticate(AccountModel model)
        {
            try
            {
                var account = new AccountModel();
                HttpResponseMessage responseMessage = await client.PostAsJsonAsync("users/Authenticate", model);
                if (responseMessage.IsSuccessStatusCode)
                {
                    account = await responseMessage.Content.ReadFromJsonAsync<AccountModel>();
                }
                return account?? new();
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
                throw ee;
            }
        }
        public async Task<List<AccountModel>> ListOfUsers(FilterParameter param)
        {
            List<AccountModel> list = new();
            HttpResponseMessage responseMessage = await client.GetAsync("users/GetUsers");
            if (responseMessage.IsSuccessStatusCode)
            {
                list = await responseMessage.Content.ReadFromJsonAsync<List<AccountModel>>();
            }
            return list ?? new();
        }

        public async Task<AccountModel> Remove(int id)
        {
            try
            {
                var account = new AccountModel();
                HttpResponseMessage responseMessage = await client.DeleteAsync("users/DeleteUser/"+id);
                if (responseMessage.IsSuccessStatusCode)
                {
                    account = await responseMessage.Content.ReadFromJsonAsync<AccountModel>();
                }
                return account ?? new();
            } catch(Exception ee)
            {
                return new();
            }
        }

        public async Task<AccountModel> UpdatePassword(int id, AccountModel model)
        {
            try
            {
                var account = new AccountModel();
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync("users/UpdateUser/"+id, model);
                if (responseMessage.IsSuccessStatusCode)
                {
                    account = await responseMessage.Content.ReadFromJsonAsync<AccountModel>();
                }
                return account ?? new();
            } catch(Exception ee)
            {
                return new();
            }
        }
    }
}
