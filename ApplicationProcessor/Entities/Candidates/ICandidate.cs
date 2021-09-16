using System;
using Ulaw.ApplicationProcessor.Enums;

namespace Ulaw.ApplicationProcessor.Entities.Candidates
{
    public interface ICandidate
    {
        string Title { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime DateOfBirth { get; set; }
        bool RequiresVisa { get; set; }
        DegreeGradeEnum DegreeGrade { get; set; }
        DegreeSubjectEnum DegreeSubject { get; set; }
    }
}
