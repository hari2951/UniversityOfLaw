using System;
using Ulaw.ApplicationProcessor.Enums;
using Ulaw.ApplicationProcessor.Handler.Application;

namespace Ulaw.ApplicationProcessor.Entity.Application
{
    public class Application : IApplication
    {
        public Application(string faculty, string CourseCode, DateTime Startdate, string Title, string FirstName, string LastName, DateTime DateOfBirth, bool requiresVisa)
        {
            this.ApplicationId = new Guid();
            this.Faculty = faculty;
            this.CourseCode = CourseCode;
            this.StartDate = Startdate;
            this.Title = Title;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.RequiresVisa = requiresVisa;
            this.DateOfBirth = DateOfBirth;
        }

        public Guid ApplicationId { get; set; }
        public string Faculty { get; set; }
        public string CourseCode { get; set; }
        public DateTime StartDate { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool RequiresVisa { get; set; }
        public DegreeGradeEnum DegreeGrade { get; set; }
        public DegreeSubjectEnum DegreeSubject { get; set; }

        public string Process()
        {
            var unSuccessfulApplication = new UnSuccessfulApplicationHandler();
            var successfulApplication = new SuccessfulApplicationHandler();
            var assessingApplication = new AssessingApplicationHandler();

            unSuccessfulApplication.SetSuccessor(successfulApplication);
            successfulApplication.SetSuccessor(assessingApplication);
            
            return unSuccessfulApplication.HandleRequest(this);
        }
    }
}

