using System;
using Ulaw.ApplicationProcessor.Enums;

namespace Ulaw.ApplicationProcessor.Entity.Application
{
    public interface IApplication
    {
        Guid ApplicationId { get; set; }
        string Faculty { get; set; }
        string CourseCode { get; set; }
        DateTime StartDate { get; set; }
        string Title { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime DateOfBirth { get; set; }
        bool RequiresVisa { get; set; }
        DegreeGradeEnum DegreeGrade { get; set; }
        DegreeSubjectEnum DegreeSubject { get; set; }

        string Process();
    }
}
