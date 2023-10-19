using UA.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace UA.Services.SectionServices
{
    public interface ISectionService
    {
        Task<List<SectionModel>> ListOfSection(FilterParameter param);
        Task<SectionModel> AddSection(SectionModel model);
        Task<SectionModel> UpdateSection(SectionModel model);
        Task<SectionModel> DeleteSection(int id);
    }
}