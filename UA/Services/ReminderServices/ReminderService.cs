using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Reflection;
using UA.Models;

namespace UA.Services.ReminderServices
{
    public class ReminderService : IReminderService
    {
        private readonly IConfiguration configuration;
        HttpClient client;
        public ReminderService(HttpClient _client, IConfiguration _config)
        {
            client = _client;
            configuration = _config;
        }

        public async Task<RemindersModel> AddReminder(RemindersModel model)
        {
           var account = new RemindersModel();
            HttpResponseMessage responseMessage = await client.PostAsJsonAsync("reminder/AddReminder", model);
            if (responseMessage.IsSuccessStatusCode)
            {
                account = await responseMessage.Content.ReadFromJsonAsync<RemindersModel>();
            }
            return account ?? new();
        }
        public async Task<List<RemindersModel>> ListReminders(FilterParameter param)
        {
            List<RemindersModel> list = new();
            HttpResponseMessage responseMessage = await client.GetAsync("reminder/GetReminders");
            if (responseMessage.IsSuccessStatusCode)
            {
                list = await responseMessage.Content.ReadFromJsonAsync<List<RemindersModel>>();
            }
            return list ?? new();
        }

        public async Task<RemindersModel> Remove(int id)
        {
            try
            {
                var account = new RemindersModel();
                HttpResponseMessage responseMessage = await client.DeleteAsync("reminder/DeleteReminder/"+id);
                if (responseMessage.IsSuccessStatusCode)
                {
                    account = await responseMessage.Content.ReadFromJsonAsync<RemindersModel>();
                }
                return account ?? new();
            } catch(Exception ee)
            {
                return new();
            }
        }

        public async Task<RemindersModel> UpdateReminder(int id, RemindersModel model)
        {
            try
            {
                var account = new RemindersModel();
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync("reminder/UpdateReminder/"+id, model);
                if (responseMessage.IsSuccessStatusCode)
                {
                    account = await responseMessage.Content.ReadFromJsonAsync<RemindersModel>();
                }
                return account ?? new();
            } catch(Exception ee)
            {
                return new();
            }
        }
    }
}
