using UA.Models;
using System.Net.Http.Json;

namespace UA.Services.DepartmentCourseServices
{
    public class DepartmentCourseService : IDepartmentCourseService
    {
        private readonly IConfiguration configuration;
        HttpClient client;
        List<DepartmentCourseModel> list = new();
        DepartmentCourseModel model = new();
        public DepartmentCourseService(HttpClient _client, IConfiguration _config)
        {
            client = _client;
            configuration = _config;
        }
        public async Task<List<DepartmentCourseModel>> ListOfDepartmentCourse(FilterParameter param)
        {

            HttpResponseMessage responseMessage = await client.PostAsJsonAsync("DepartmentCourse/List", param);
            if (responseMessage.IsSuccessStatusCode)
            {
                list = await responseMessage.Content.ReadFromJsonAsync<List<DepartmentCourseModel>>();
            }
            return list?? new();
        }
        public async Task<DepartmentCourseModel> AddDepartmentCourse(DepartmentCourseModel model)
        {
            HttpResponseMessage responseMessage = await client.PostAsJsonAsync("DepartmentCourse/AddDepartmentCourse", model);
            if (responseMessage.IsSuccessStatusCode)
            {
                model = await responseMessage.Content.ReadFromJsonAsync<DepartmentCourseModel>();
            }
            return model?? new();
        }
        public async Task<DepartmentCourseModel> UpdateDepartmentCourse(DepartmentCourseModel model)
        {
            HttpResponseMessage responseMessage = await client.PutAsJsonAsync(String.Format("DepartmentCourse/UpdateDepartmentCourse/{0}", model.DepartmentCourseId), model);
            if (responseMessage.IsSuccessStatusCode)
            {
                model = await responseMessage.Content.ReadFromJsonAsync<DepartmentCourseModel>();
            }
            return model?? new();
        }
        public async Task<DepartmentCourseModel> DeleteDepartmentCourse(int id)
        {
            HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("DepartmentCourse/DeleteDepartmentCourse/{0}",id));
            if (responseMessage.IsSuccessStatusCode)
            {
                model = await responseMessage.Content.ReadFromJsonAsync<DepartmentCourseModel>();
            }
            return model?? new();
        }
        public async Task<List<DepartmentCourseModel>> GetDepartmentCourses(int deptId)
        {
            HttpResponseMessage responseMessage = await client.GetAsync(String.Format("DepartmentCourse/GetDepartmentCourse/{0}", deptId));
            if (responseMessage.IsSuccessStatusCode)
            {
                list = await responseMessage.Content.ReadFromJsonAsync<List<DepartmentCourseModel>>();
            }
            return list?? new();
        }
    }
}