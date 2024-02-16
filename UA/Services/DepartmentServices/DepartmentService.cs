using UA.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace UA.Services.DepartmentServices
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IConfiguration configuration;
        HttpClient client;
        List<DepartmentModel> list = new();
        DepartmentModel model = new();
        public DepartmentService(HttpClient _client, IConfiguration _config)
        {
            client = _client;
            configuration = _config;
        }
        public async Task<List<DepartmentModel>> ListOfDepartment(FilterParameter param)
        {

            HttpResponseMessage responseMessage = await client.PostAsJsonAsync("department/List", param);
            if (responseMessage.IsSuccessStatusCode)
            {
                list = await responseMessage.Content.ReadFromJsonAsync<List<DepartmentModel>>();
            }
            return list?? new();
        }
        public async Task<List<DepartmentModel>> CollegesMasterList(FilterParameter param)
        {

            HttpResponseMessage responseMessage = await client.PostAsJsonAsync("department/CollegesMasterList", param);
            if (responseMessage.IsSuccessStatusCode)
            {
                list = await responseMessage.Content.ReadFromJsonAsync<List<DepartmentModel>>();
            }
            return list?? new();
        }
        public async Task<DepartmentModel> AddDepartment(DepartmentModel model)
        {
            HttpResponseMessage responseMessage = await client.PostAsJsonAsync("department/AddDepartment", model);
            if (responseMessage.IsSuccessStatusCode)
            {
                model = await responseMessage.Content.ReadFromJsonAsync<DepartmentModel>();
            }
            return model?? new();
        }
        public async Task<DepartmentModel> UpdateDepartment(DepartmentModel model)
        {
            HttpResponseMessage responseMessage = await client.PutAsJsonAsync(String.Format("department/UpdateDepartment/{0}", model.DepartmentId), model);
            if (responseMessage.IsSuccessStatusCode)
            {
                model = await responseMessage.Content.ReadFromJsonAsync<DepartmentModel>();
            }
            return model?? new();
        }
        public async Task<DepartmentModel> DeleteDepartment(int id)
        {
            HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("department/DeleteDepartment/{0}",id));
            if (responseMessage.IsSuccessStatusCode)
            {
                model = await responseMessage.Content.ReadFromJsonAsync<DepartmentModel>();
            }
            return model?? new();
        }
    }
}