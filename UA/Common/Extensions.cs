
using MudBlazor;
using System.ComponentModel;
using System.Reflection;

namespace UA.Common
{
    public class Extensions
    {
        public static void ShowAlert(string message, Variant variant, ISnackbar snackbarService, Severity severityType)
        {
            snackbarService.Clear();
            snackbarService.Configuration.PositionClass = Defaults.Classes.Position.BottomCenter;
            snackbarService.Configuration.SnackbarVariant = variant;
            snackbarService.Configuration.MaxDisplayedSnackbars = 10;
            snackbarService.Configuration.VisibleStateDuration = 2000;
            snackbarService.Add($"{message}", severityType);
        }
        public static string GetEnumDescription(Enum value)  
        {  
            var enumMember = value.GetType().GetMember(value.ToString()).FirstOrDefault();  
            var descriptionAttribute =  
                enumMember == null  
                    ? default(DescriptionAttribute)  
                    : enumMember.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;  
            return  
                descriptionAttribute == null  
                    ? value.ToString()  
                    : descriptionAttribute.Description;  
        }
        public static MudBlazor.Color DepartmentColor(int c)
        {
            switch(c)
            {
                case 1:
                return MudBlazor.Color.Primary;
                case 2:
                return MudBlazor.Color.Secondary;
                case 3:
                return MudBlazor.Color.Info;
                case 4:
                return MudBlazor.Color.Success;
                case 5:
                return MudBlazor.Color.Warning;
                case 6:
                return MudBlazor.Color.Error;
                default:
                return MudBlazor.Color.Secondary;
            }
        }
    }
}