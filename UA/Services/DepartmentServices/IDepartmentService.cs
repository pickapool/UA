using UA.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace UA.Services.DepartmentServices
{
    public interface IDepartmentService
    {
        Task<List<DepartmentModel>> ListOfDepartment(FilterParameter param);
        Task<DepartmentModel> AddDepartment(DepartmentModel model);
        Task<DepartmentModel> UpdateDepartment(DepartmentModel model);
        Task<DepartmentModel> DeleteDepartment(int id);
    }
}