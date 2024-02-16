using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using UA;
using UA.Services.AccountServices;
using UA.Services.DepartmentServices;
using UA.Services.SanctionServices;
using UA.Services.CourseServices;
using UA.Services.SectionServices;
using UA.Services.StudentServices;
using UA.Services.UserSanctionServices;
using UA.Services.DepartmentCourseServices;
using Microsoft.AspNetCore.Http.Features;
using UA.Services;
using UA.Services.ReportServices;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration.GetValue<string>("BaseAPIUrl")) });
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddMudServices();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddScoped<ISanctionService, SanctionService>();
builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<ISectionService, SectionService>();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<IUserSanctionService, UserSanctionService>();
builder.Services.AddScoped<IDepartmentCourseService, DepartmentCourseService>();
builder.Services.AddScoped<IReportService, ReportService>();

builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();

builder.Services.Configure<FormOptions>(options =>
{
    options.MultipartBodyLengthLimit = 209715200; // Set to 200 MB (200 * 1024 * 1024 bytes)
});

await builder.Build().RunAsync();
