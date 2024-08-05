using UA.Models;

namespace UA.Services.ReminderServices
{
    public interface IReminderService
    {
        Task<RemindersModel> UpdateReminder(int id, RemindersModel model);
        Task<List<RemindersModel>> ListReminders(FilterParameter param);
        Task<RemindersModel> AddReminder(RemindersModel model);
        Task<RemindersModel> Remove(int id);
    }
}
