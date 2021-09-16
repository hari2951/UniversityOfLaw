using System;

namespace Ulaw.ApplicationProcessor.Entity.Courses
{
    public interface ICourse
    {
        string Faculty { get; set; }
        string CourseCode { get; set; }
        DateTime StartDate { get; set; }
    }
}
