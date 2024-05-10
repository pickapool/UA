using UA.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace UA.Services.StudentServices
{
    public interface IStudentService
    {
        Task<List<StudentModel>> ListOfStudent(FilterParameter param);
        Task<StudentModel> AddStudent(StudentModel model);
        Task<StudentModel> UpdateStudent(StudentModel model);
        Task<StudentModel> DeleteStudent(int id);
        Task<StudentModel> GetStudentByFace(string face);
    }
}