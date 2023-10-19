using UA.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace UA.Services.CourseServices
{
    public interface ICourseService
    {
        Task<List<CourseModel>> ListOfCourse(FilterParameter param);
        Task<CourseModel> AddCourse(CourseModel model);
        Task<CourseModel> UpdateCourse(CourseModel model);
        Task<CourseModel> DeleteCourse(int id);
    }
}