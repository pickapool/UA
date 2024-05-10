using UA.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace UA.Services.EventServices
{
    public class EventService : IEventService
    {
        private readonly IConfiguration configuration;
        HttpClient client;
        List<EventModel> list = new();
        EventModel model = new();
        public EventService(HttpClient _client, IConfiguration _config)
        {
            client = _client;
            configuration = _config;
        }
        public async Task<List<EventModel>> ListOfEvent(FilterParameter param)
        {

            HttpResponseMessage responseMessage = await client.PostAsJsonAsync("Event/List", param);
            if (responseMessage.IsSuccessStatusCode)
            {
                list = await responseMessage.Content.ReadFromJsonAsync<List<EventModel>>();
            }
            return list?? new();
        }
        public async Task<EventModel> AddEvent(EventModel model)
        {
            HttpResponseMessage responseMessage = await client.PostAsJsonAsync("Event/AddEvent", model);
            if (responseMessage.IsSuccessStatusCode)
            {
                model = await responseMessage.Content.ReadFromJsonAsync<EventModel>();
            }
            return model?? new();
        }
        public async Task<EventModel> UpdateEvent(EventModel model)
        {
            HttpResponseMessage responseMessage = await client.PutAsJsonAsync(String.Format("Event/UpdateEvent/{0}", model.EventId), model);
            if (responseMessage.IsSuccessStatusCode)
            {
                model = await responseMessage.Content.ReadFromJsonAsync<EventModel>();
            }
            return model?? new();
        }
        public async Task<EventModel> DeleteEvent(int id)
        {
            HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("Event/DeleteEvent/{0}",id));
            if (responseMessage.IsSuccessStatusCode)
            {
                model = await responseMessage.Content.ReadFromJsonAsync<EventModel>();
            }
            return model?? new();
        }
    }
}