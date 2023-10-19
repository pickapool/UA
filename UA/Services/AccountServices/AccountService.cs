using System.Net.Http.Headers;
using System.Net.Http.Json;
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
    }
}
