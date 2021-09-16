using System;
using Ulaw.ApplicationProcessor.Entities.Candidates;
using Ulaw.ApplicationProcessor.Entities.Courses;
using Ulaw.ApplicationProcessor.Handler.Application;

namespace Ulaw.ApplicationProcessor.Entities.Application
{
    public class Application : IApplication
    {
        public Application(ICandidate candidate, ICourse course)
        {
            ApplicationId = new Guid();
            Candidate = candidate;
            Course = course;
        }

        public Guid ApplicationId { get; set; }
        public ICandidate Candidate { get; set; }
        public ICourse Course { get; set; }

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

