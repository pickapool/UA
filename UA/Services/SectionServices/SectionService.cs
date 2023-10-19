using UA.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace UA.Services.SectionServices
{
    public class SectionService : ISectionService
    {
        private readonly IConfiguration configuration;
        HttpClient client;
        List<SectionModel> list = new();
        SectionModel model = new();
        public SectionService(HttpClient _client, IConfiguration _config)
        {
            client = _client;
            configuration = _config;
        }
        public async Task<List<SectionModel>> ListOfSection(FilterParameter param)
        {

            HttpResponseMessage responseMessage = await client.PostAsJsonAsync("Section/List", param);
            if (responseMessage.IsSuccessStatusCode)
            {
                list = await responseMessage.Content.ReadFromJsonAsync<List<SectionModel>>();
            }
            return list?? new();
        }
        public async Task<SectionModel> AddSection(SectionModel model)
        {
            HttpResponseMessage responseMessage = await client.PostAsJsonAsync("Section/AddSection", model);
            if (responseMessage.IsSuccessStatusCode)
            {
                model = await responseMessage.Content.ReadFromJsonAsync<SectionModel>();
            }
            return model?? new();
        }
        public async Task<SectionModel> UpdateSection(SectionModel model)
        {
            HttpResponseMessage responseMessage = await client.PutAsJsonAsync(String.Format("Section/UpdateSection/{0}", model.SectionId), model);
            if (responseMessage.IsSuccessStatusCode)
            {
                model = await responseMessage.Content.ReadFromJsonAsync<SectionModel>();
            }
            return model?? new();
        }
        public async Task<SectionModel> DeleteSection(int id)
        {
            HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("Section/DeleteSection/{0}",id));
            if (responseMessage.IsSuccessStatusCode)
            {
                model = await responseMessage.Content.ReadFromJsonAsync<SectionModel>();
            }
            return model?? new();
        }
    }
}