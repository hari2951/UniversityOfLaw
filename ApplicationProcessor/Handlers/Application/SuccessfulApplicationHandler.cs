using Ulaw.ApplicationProcessor.Entities.Application;
using Ulaw.ApplicationProcessor.Enums;
using Ulaw.ApplicationProcessor.Templates;

namespace Ulaw.ApplicationProcessor.Handler.Application
{
    public class SuccessfulApplicationHandler : ApplicationHandler
    {
        public override string HandleRequest(IApplication application)
        {
            if (application?.Candidate?.DegreeGrade != DegreeGradeEnum.TwoTwo
              && (application?.Candidate?.DegreeSubject == DegreeSubjectEnum.Law
              || application?.Candidate?.DegreeSubject == DegreeSubjectEnum.LawAndBusiness))
            {
                return GetHTMLTemplates.GetSuccessfulApplicationTemplate(application);
            }

            return base.HandleRequest(application);

        }
    }
}
