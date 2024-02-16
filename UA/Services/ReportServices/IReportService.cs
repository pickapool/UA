using UA.Models;

namespace UA.Services.ReportServices
{
    public interface IReportService
    {
        Task<string> GetMasterListReport(List<StudentModel> vouchers);
    }
}