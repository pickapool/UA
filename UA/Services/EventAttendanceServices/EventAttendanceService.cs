using UA.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace UA.Services.EventAttendanceServices
{
    public class EventAttendanceService : IEventAttendanceService
    {
        private readonly IConfiguration configuration;
        HttpClient client;
        List<EventAttendanceModel> list = new();
        EventAttendanceModel model = new();
        public EventAttendanceService(HttpClient _client, IConfiguration _config)
        {
            client = _client;
            configuration = _config;
        }
        public async Task<List<EventAttendanceModel>> ListOfEventAttendance(FilterParameter param)
        {

            HttpResponseMessage responseMessage = await client.PostAsJsonAsync("EventAttendance/List", param);
            if (responseMessage.IsSuccessStatusCode)
            {
                list = await responseMessage.Content.ReadFromJsonAsync<List<EventAttendanceModel>>();
            }
            return list?? new();
        }
        public async Task<EventAttendanceModel> AddEventAttendance(EventAttendanceModel model)
        {
            HttpResponseMessage responseMessage = await client.PostAsJsonAsync("EventAttendance/AddEventAttendance", model);
            if (responseMessage.IsSuccessStatusCode)
            {
                model = await responseMessage.Content.ReadFromJsonAsync<EventAttendanceModel>();
            }
            return model?? new();
        }
        public async Task<EventAttendanceModel> UpdateEventAttendance(EventAttendanceModel model)
        {
            HttpResponseMessage responseMessage = await client.PutAsJsonAsync(String.Format("EventAttendance/UpdateEventAttendance/{0}", model.EventAttendanceId), model);
            if (responseMessage.IsSuccessStatusCode)
            {
                model = await responseMessage.Content.ReadFromJsonAsync<EventAttendanceModel>();
            }
            return model?? new();
        }
        public async Task<EventAttendanceModel> DeleteEventAttendance(int id)
        {
            HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("EventAttendance/DeleteEventAttendance/{0}",id));
            if (responseMessage.IsSuccessStatusCode)
            {
                model = await responseMessage.Content.ReadFromJsonAsync<EventAttendanceModel>();
            }
            return model?? new();
        }
    }
}