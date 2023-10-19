using System.ComponentModel;
namespace UA.Enums
{
    public class Enums
    {
        public enum YearLevel : byte{ 
            [Description("1st year")]
            Firstyear = 1,
            [Description("2nd year")]
            SecondYear = 2,
            [Description("3rd year")]
            ThridYear = 3,
            [Description("4th year")]
            FourthYear = 4,
            [Description("5th year")]
            Fifthyear = 5,
        }
    }
}
