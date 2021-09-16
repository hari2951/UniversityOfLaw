using System.ComponentModel;

namespace Ulaw.ApplicationProcessor.Enums
{
    public enum DegreeSubjectEnum : int
    {
        [DescriptionAttribute("Law")]
        Law,
        [DescriptionAttribute("Law and Business")]
        LawAndBusiness,
        [DescriptionAttribute("Maths")]
        Maths,
        [DescriptionAttribute("English")]
        English
    }
}