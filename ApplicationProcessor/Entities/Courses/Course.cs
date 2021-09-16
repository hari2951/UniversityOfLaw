using System;

namespace Ulaw.ApplicationProcessor.Entities.Courses
{
    public class Course : ICourse
    {
        public string Faculty { get; set; }
        public string CourseCode { get; set; }
        public DateTime StartDate { get; set; }
    }
}