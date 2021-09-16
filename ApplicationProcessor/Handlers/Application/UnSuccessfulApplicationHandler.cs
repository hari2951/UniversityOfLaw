using Ulaw.ApplicationProcessor.Entities.Application;
using Ulaw.ApplicationProcessor.Enums;
using Ulaw.ApplicationProcessor.Templates;

namespace Ulaw.ApplicationProcessor.Handler.Application
{
    public class UnSuccessfulApplicationHandler : ApplicationHandler
    {
        public override string HandleRequest(IApplication application)
        {
            if (application.Candidate.DegreeGrade == DegreeGradeEnum.Third)
            {
                return GetHTMLTemplates.GetUnSuccessfulApplicationTemplate(application);
            }

            return base.HandleRequest(application);
        }
    }
}