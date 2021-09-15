using System.ComponentModel;

namespace Ulaw.ApplicationProcessor.Enums
{
    public enum DegreeSubjectEnum : int
    {
        [DescriptionAttribute("Law")]
        law,
        [DescriptionAttribute("Law and Business")]
        lawAndBusiness,
        [DescriptionAttribute("Maths")]
        maths,
        [DescriptionAttribute("English")]
        English
    }
}