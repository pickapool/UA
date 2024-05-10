using UA.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace UA.Services.EventAttendanceServices
{
    public interface IEventAttendanceService
    {
        Task<List<EventAttendanceModel>> ListOfEventAttendance(FilterParameter param);
        Task<EventAttendanceModel> AddEventAttendance(EventAttendanceModel model);
        Task<EventAttendanceModel> UpdateEventAttendance(EventAttendanceModel model);
        Task<EventAttendanceModel> DeleteEventAttendance(int id);
    }
}