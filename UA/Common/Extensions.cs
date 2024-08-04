
using MudBlazor;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Reflection;

namespace UA.Common
{
    public static class Extensions
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
        public static string FormatPassword(string password, char symbol = '●')
        {
            // Create a character array to store the formatted password
            char[] formattedPassword = new char[password.Length];
            
            // Fill the array with the specified symbol
            for (int i = 0; i < password.Length; i++)
            {
                formattedPassword[i] = symbol;
            }
            
            // Convert the character array back to a string
            return new string(formattedPassword);
        }
        public static T CloneJson<T>(this T source)
        {            
            // Don't serialize a null object, simply return the default for that object
            if (ReferenceEquals(source, null)) return default;

            // initialize inner objects individually
            // for example in default constructor some list property initialized with some values,
            // but in 'source' these items are cleaned -
            // without ObjectCreationHandling.Replace default constructor values will be added to result
            var deserializeSettings = new JsonSerializerSettings {ObjectCreationHandling = ObjectCreationHandling.Replace};

            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(source), deserializeSettings);
        }
    }
}