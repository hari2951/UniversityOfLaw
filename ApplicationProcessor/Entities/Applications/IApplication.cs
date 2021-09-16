using System;
using Ulaw.ApplicationProcessor.Entity.Candidates;
using Ulaw.ApplicationProcessor.Entity.Courses;
using Ulaw.ApplicationProcessor.Enums;

namespace Ulaw.ApplicationProcessor.Entity.Application
{
    public interface IApplication
    {
        Guid ApplicationId { get; set; }
        ICandidate Candidate { get; set; }
        ICourse Course { get; set; }

        string Process();
    }
}
