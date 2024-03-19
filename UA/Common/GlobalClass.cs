using UA.Models;
using UA.Pages;

namespace UA.Common
{
    public class GlobalClass
    {
        public static bool IsLogin = false;
        public static string pageTitle = string.Empty;
        public static bool ShowLogin = false;
        public static string QRCode = string.Empty;
        public static List<CourseModel> ListOfCourse = new();
        public static List<DepartmentModel> ListOfDepartments = new();
        public static List<SectionModel> ListOfSections = new();
        public static AccountModel Account = new AccountModel();
    }
}