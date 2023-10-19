using UA.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace UA.Services.StudentServices
{
    public class StudentService : IStudentService
    {
        private readonly IConfiguration configuration;
        HttpClient client;
        List<StudentModel> list = new();
        StudentModel model = new();
        public StudentService(HttpClient _client, IConfiguration _config)
        {
            client = _client;
            configuration = _config;
        }
        public async Task<List<StudentModel>> ListOfStudent(FilterParameter param)
        {

            HttpResponseMessage responseMessage = await client.PostAsJsonAsync("Student/List", param);
            if (responseMessage.IsSuccessStatusCode)
            {
                list = await responseMessage.Content.ReadFromJsonAsync<List<StudentModel>>();
            }
            return list?? new();
        }
        public async Task<StudentModel> AddStudent(StudentModel model)
        {
            HttpResponseMessage responseMessage = await client.PostAsJsonAsync("Student/AddStudent", model);
            if (responseMessage.IsSuccessStatusCode)
            {
                model = await responseMessage.Content.ReadFromJsonAsync<StudentModel>();
            }
            return model?? new();
        }
        public async Task<StudentModel> UpdateStudent(StudentModel model)
        {
            HttpResponseMessage responseMessage = await client.PutAsJsonAsync(String.Format("Student/UpdateStudent/{0}", model.StudentId), model);
            if (responseMessage.IsSuccessStatusCode)
            {
                model = await responseMessage.Content.ReadFromJsonAsync<StudentModel>();
            }
            return model?? new();
        }
        public async Task<StudentModel> DeleteStudent(int id)
        {
            HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("Student/DeleteStudent/{0}",id));
            if (responseMessage.IsSuccessStatusCode)
            {
                model = await responseMessage.Content.ReadFromJsonAsync<StudentModel>();
            }
            return model?? new();
        }
    }
}