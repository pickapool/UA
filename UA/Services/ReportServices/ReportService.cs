using System.Net.Http.Json;
using UA.Models;

namespace UA.Services.ReportServices
{
    public class ReportService : IReportService
    {
        private readonly HttpClient client;
        public ReportService(HttpClient _client)
        {
            this.client = _client;
        }

        public async Task<string> GetMasterListReport(List<StudentModel> depts)
        {
            var pdfContent = "data:application/pdf;base64,";
            HttpResponseMessage responseMessage = await client.PostAsJsonAsync("Report/GetMasterListReport", depts);
            if (responseMessage.IsSuccessStatusCode)
                pdfContent += Convert.ToBase64String(await responseMessage.Content.ReadAsByteArrayAsync());
            return pdfContent;
        }
    }
}