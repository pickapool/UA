using UA.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace UA.Services.SanctionServices
{
    public interface ISanctionService
    {
        Task<List<SanctionModel>> ListOfSanction(FilterParameter param);
        Task<SanctionModel> AddSanction(SanctionModel model);
        Task<SanctionModel> UpdateSanction(SanctionModel model);
        Task<SanctionModel> DeleteSanction(int id);
    }
}