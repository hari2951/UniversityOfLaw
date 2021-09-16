using Ulaw.ApplicationProcessor.Entity.Application;
using Ulaw.ApplicationProcessor.Enums;
using Ulaw.ApplicationProcessor.Templates;

namespace Ulaw.ApplicationProcessor.Handler.Application
{
    public class SuccessfulApplicationHandler : ApplicationHandler
    {
        public override string HandleRequest(IApplication application)
        {
            if (application.DegreeGrade != DegreeGradeEnum.twoTwo && (application.DegreeSubject == DegreeSubjectEnum.law || application.DegreeSubject == DegreeSubjectEnum.lawAndBusiness))
            {
                return GetHTMLTemplates.GetSuccessfulApplicationTemplate(application);
            }

            return base.HandleRequest(application);
        }
    }
}
