using System.ComponentModel;

namespace Ulaw.ApplicationProcessor.Enums
{
    public enum DegreeGradeEnum : int
    {
        [DescriptionAttribute("1st")]
        First,
        [DescriptionAttribute("2:1")]
        TwoOne,
        [DescriptionAttribute("2:2")]
        TwoTwo,
        [DescriptionAttribute("3rd")]
        Third
    }
}