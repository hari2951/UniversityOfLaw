using Ulaw.ApplicationProcessor.Entity.Application;
using Ulaw.ApplicationProcessor.Enums;
using Ulaw.ApplicationProcessor.Templates;

namespace Ulaw.ApplicationProcessor.Handler.Application
{
    public class SuccessfulApplicationHandler : ApplicationHandler
    {
        public override string HandleRequest(IApplication application)
        {
            if (application.Candidate.DegreeGrade != DegreeGradeEnum.twoTwo 
                && (application.Candidate.DegreeSubject == DegreeSubjectEnum.law
                || application.Candidate.DegreeSubject == DegreeSubjectEnum.lawAndBusiness))
            {
                return GetHTMLTemplates.GetSuccessfulApplicationTemplate(application);
            }

            return base.HandleRequest(application);
        }
    }
}
