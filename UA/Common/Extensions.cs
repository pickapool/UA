
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
        public static Color DepartmentColor(int c)
        {
            switch(c)
            {
                case 1:
                return Color.Primary;
                case 2:
                return Color.Secondary;
                case 3:
                return Color.Info;
                case 4:
                return Color.Success;
                case 5:
                return Color.Warning;
                case 6:
                return Color.Error;
                default:
                return Color.Secondary;
            }
        }
    }
}