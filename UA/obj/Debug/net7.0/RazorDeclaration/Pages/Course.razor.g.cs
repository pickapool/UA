// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace UA.Pages
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line (1,2)-(1,23) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line (2,2)-(2,28) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using System.Net.Http.Json

#nullable disable
    ;
#nullable restore
#line (3,2)-(3,45) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line (4,2)-(4,47) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line (5,2)-(5,43) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line (6,2)-(6,58) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization

#nullable disable
    ;
#nullable restore
#line (7,2)-(7,56) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http

#nullable disable
    ;
#nullable restore
#line (8,2)-(8,27) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line (9,2)-(9,10) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using UA

#nullable disable
    ;
#nullable restore
#line (10,2)-(10,17) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using UA.Shared

#nullable disable
    ;
#nullable restore
#line (11,2)-(11,53) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line (12,2)-(12,42) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line (13,2)-(13,49) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using System.Runtime.InteropServices.JavaScript

#nullable disable
    ;
#nullable restore
#line (15,2)-(15,29) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using Blazored.LocalStorage

#nullable disable
    ;
#nullable restore
#line (16,2)-(16,17) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using MudBlazor

#nullable disable
    ;
#nullable restore
#line (17,2)-(17,26) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using Blazored.Typeahead

#nullable disable
    ;
#nullable restore
#line (18,2)-(18,27) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using MudBlazor.Utilities

#nullable disable
    ;
#nullable restore
#line (19,2)-(19,20) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using IronBarCode;

#nullable disable
#nullable restore
#line (20,2)-(20,21) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using OfficeOpenXml

#nullable disable
    ;
#nullable restore
#line (22,2)-(22,21) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using UA.Components

#nullable disable
    ;
#nullable restore
#line (23,2)-(23,17) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using UA.Common

#nullable disable
    ;
#nullable restore
#line (24,2)-(24,16) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using UA.Enums

#nullable disable
    ;
#nullable restore
#line (25,2)-(25,17) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using UA.Models

#nullable disable
    ;
#nullable restore
#line (26,2)-(26,18) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using UA.Dialogs

#nullable disable
    ;
#nullable restore
#line (28,2)-(28,35) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using UA.Services.AccountServices

#nullable disable
    ;
#nullable restore
#line (29,2)-(29,38) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using UA.Services.DepartmentServices

#nullable disable
    ;
#nullable restore
#line (30,2)-(30,36) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using UA.Services.SanctionServices

#nullable disable
    ;
#nullable restore
#line (31,2)-(31,34) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using UA.Services.CourseServices

#nullable disable
    ;
#nullable restore
#line (32,2)-(32,35) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using UA.Services.SectionServices

#nullable disable
    ;
#nullable restore
#line (33,2)-(33,35) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using UA.Services.StudentServices

#nullable disable
    ;
#nullable restore
#line (34,2)-(34,40) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using UA.Services.UserSanctionServices

#nullable disable
    ;
#nullable restore
#line (35,2)-(35,44) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using UA.Services.DepartmentCourseServices

#nullable disable
    ;
#nullable restore
#line (36,2)-(36,34) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using UA.Services.ReportServices

#nullable disable
    ;
#nullable restore
#line (37,2)-(37,33) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using UA.Services.EventServices

#nullable disable
    ;
#nullable restore
#line (38,2)-(38,43) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using UA.Services.EventAttendanceServices

#nullable disable
    ;
#nullable restore
#line (39,2)-(39,36) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using UA.Services.ReminderServices

#nullable disable
    ;
#nullable restore
#line (41,2)-(41,43) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\_Imports.razor"
using Microsoft.AspNetCore.SignalR.Client

#nullable disable
    ;
    #line default
    #line hidden
    #nullable restore
    public partial class Course : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line (89,8)-(146,1) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\Pages\Course.razor"

    List<CourseModel> list = new();
    private int[] pageSize = new int[] {30, 50, 100, 500, 1000 };
    private string searchTerm = string.Empty;
    private bool IsLoading = true;

    protected override async Task OnInitializedAsync()
    {
        GlobalClass.pageTitle = "Courses";
        await GetList();
    }
    private async Task GetList()
    {
        IsLoading = true;
        Task<List<CourseModel>> data = CourseService.ListOfCourse(new FilterParameter());
        await data;
        if (data.Status == TaskStatus.RanToCompletion)
        {
            list = data.Result;
            await Task.Delay(1000);
            IsLoading = false;
            StateHasChanged();
        }
    }
    private bool FilterItems(CourseModel items)
    {
        if (string.IsNullOrEmpty(searchTerm))
            return true;
        if (items.CourseName.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase))
            return true;
        return false;
    }
    private async Task EditCourse(CourseModel dept)
    {
        var parameters = new DialogParameters();
        parameters.Add("color", dept.CourseId == 0 ? Color.Info : Color.Success);
        parameters.Add("dialogTitle", dept.CourseId == 0 ? "Add Course" : "Edit Course");
        parameters.Add("buttonText", dept.CourseId == 0 ? "Add" : "Save");
        parameters.Add("CourseModel", dept);
        var options = new DialogOptions() { CloseButton = false, MaxWidth = MaxWidth.ExtraSmall, FullWidth = true, NoHeader = false, DisableBackdropClick = false };
        var resultDialog = await dialogService.Show<Dialogs.CourseDialog>("", parameters, options).Result;
        if (!resultDialog.Canceled)
        {
            await GetList();
        }
    }
    private async Task DeleteCourse(int id)
    {
        IsLoading = !IsLoading;
        Task t = CourseService.DeleteCourse(id);
        await t;
        if(t.Status == TaskStatus.RanToCompletion)
        {
            await GetList();
            Extensions.ShowAlert("Course successfully remove.", Variant.Filled, Snackbar, Severity.Success);
        }
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line (3,9)-(3,18) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\Pages\Course.razor"
ISnackbar

#line default
#line hidden
#nullable disable
         
#nullable restore
#line (3,19)-(3,27) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\Pages\Course.razor"
Snackbar

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line (2,9)-(2,23) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\Pages\Course.razor"
IDialogService

#line default
#line hidden
#nullable disable
         
#nullable restore
#line (2,24)-(2,37) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\Pages\Course.razor"
dialogService

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line (1,9)-(1,23) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\Pages\Course.razor"
ICourseService

#line default
#line hidden
#nullable disable
         
#nullable restore
#line (1,24)-(1,37) "C:\Users\User\Desktop\Projects\Blazor Projects\UA\UA\Pages\Course.razor"
CourseService

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591
