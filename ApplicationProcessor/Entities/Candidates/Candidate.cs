using System;
using Ulaw.ApplicationProcessor.Enums;

namespace Ulaw.ApplicationProcessor.Entity.Candidates
{
    public class Candidate : ICandidate
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool RequiresVisa { get; set; }
        public DegreeGradeEnum DegreeGrade { get; set; }
        public DegreeSubjectEnum DegreeSubject { get; set; }
    }
}
