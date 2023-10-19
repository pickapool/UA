using UA.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace UA.Services.SanctionServices
{
    public class SanctionService : ISanctionService
    {
        private readonly IConfiguration configuration;
        HttpClient client;
        List<SanctionModel> list = new();
        SanctionModel model = new();
        public SanctionService(HttpClient _client, IConfiguration _config)
        {
            client = _client;
            configuration = _config;
        }
        public async Task<List<SanctionModel>> ListOfSanction(FilterParameter param)
        {

            HttpResponseMessage responseMessage = await client.PostAsJsonAsync("sanction/List", param);
            if (responseMessage.IsSuccessStatusCode)
            {
                list = await responseMessage.Content.ReadFromJsonAsync<List<SanctionModel>>();
            }
            return list?? new();
        }
        public async Task<SanctionModel> AddSanction(SanctionModel model)
        {
            HttpResponseMessage responseMessage = await client.PostAsJsonAsync("sanction/AddSanction", model);
            if (responseMessage.IsSuccessStatusCode)
            {
                model = await responseMessage.Content.ReadFromJsonAsync<SanctionModel>();
            }
            return model?? new();
        }
        public async Task<SanctionModel> UpdateSanction(SanctionModel model)
        {
            HttpResponseMessage responseMessage = await client.PutAsJsonAsync(String.Format("sanction/UpdateSanction/{0}", model.SanctionId), model);
            if (responseMessage.IsSuccessStatusCode)
            {
                model = await responseMessage.Content.ReadFromJsonAsync<SanctionModel>();
            }
            return model?? new();
        }
        public async Task<SanctionModel> DeleteSanction(int id)
        {
            HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("sanction/DeleteSanction/{0}",id));
            if (responseMessage.IsSuccessStatusCode)
            {
                model = await responseMessage.Content.ReadFromJsonAsync<SanctionModel>();
            }
            return model?? new();
        }
    }
}