using UA.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace UA.Services.EventServices
{
    public interface IEventService
    {
        Task<List<EventModel>> ListOfEvent(FilterParameter param);
        Task<EventModel> AddEvent(EventModel model);
        Task<EventModel> UpdateEvent(EventModel model);
        Task<EventModel> DeleteEvent(int id);
    }
}