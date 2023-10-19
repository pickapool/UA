using UA.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace UA.Services.CourseServices
{
    public class CourseService : ICourseService
    {
        private readonly IConfiguration configuration;
        HttpClient client;
        List<CourseModel> list = new();
        CourseModel model = new();
        public CourseService(HttpClient _client, IConfiguration _config)
        {
            client = _client;
            configuration = _config;
        }
        public async Task<List<CourseModel>> ListOfCourse(FilterParameter param)
        {

            HttpResponseMessage responseMessage = await client.PostAsJsonAsync("Course/List", param);
            if (responseMessage.IsSuccessStatusCode)
            {
                list = await responseMessage.Content.ReadFromJsonAsync<List<CourseModel>>();
            }
            return list?? new();
        }
        public async Task<CourseModel> AddCourse(CourseModel model)
        {
            HttpResponseMessage responseMessage = await client.PostAsJsonAsync("Course/AddCourse", model);
            if (responseMessage.IsSuccessStatusCode)
            {
                model = await responseMessage.Content.ReadFromJsonAsync<CourseModel>();
            }
            return model?? new();
        }
        public async Task<CourseModel> UpdateCourse(CourseModel model)
        {
            HttpResponseMessage responseMessage = await client.PutAsJsonAsync(String.Format("Course/UpdateCourse/{0}", model.CourseId), model);
            if (responseMessage.IsSuccessStatusCode)
            {
                model = await responseMessage.Content.ReadFromJsonAsync<CourseModel>();
            }
            return model?? new();
        }
        public async Task<CourseModel> DeleteCourse(int id)
        {
            HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("Course/DeleteCourse/{0}",id));
            if (responseMessage.IsSuccessStatusCode)
            {
                model = await responseMessage.Content.ReadFromJsonAsync<CourseModel>();
            }
            return model?? new();
        }
    }
}