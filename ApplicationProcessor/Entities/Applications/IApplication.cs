using System;
using Ulaw.ApplicationProcessor.Entities.Candidates;
using Ulaw.ApplicationProcessor.Entities.Courses;
using Ulaw.ApplicationProcessor.Enums;

namespace Ulaw.ApplicationProcessor.Entities.Application
{
    public interface IApplication
    {
        Guid ApplicationId { get; set; }
        ICandidate Candidate { get; set; }
        ICourse Course { get; set; }

        string Process();
    }
}
