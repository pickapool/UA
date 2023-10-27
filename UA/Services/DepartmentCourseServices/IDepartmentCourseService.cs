using UA.Models;

namespace UA.Services.DepartmentCourseServices
{
    public interface IDepartmentCourseService
    {
        Task<List<DepartmentCourseModel>> ListOfDepartmentCourse(FilterParameter param);
        Task<DepartmentCourseModel> AddDepartmentCourse(DepartmentCourseModel model);
        Task<DepartmentCourseModel> UpdateDepartmentCourse(DepartmentCourseModel model);
        Task<DepartmentCourseModel> DeleteDepartmentCourse(int id);
        Task<List<DepartmentCourseModel>> GetDepartmentCourses(int deptId);
    }
}