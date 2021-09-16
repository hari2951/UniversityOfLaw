using Ulaw.ApplicationProcessor.Entity.Application;
using Ulaw.ApplicationProcessor.Enums;
using Ulaw.ApplicationProcessor.Helper;

namespace Ulaw.ApplicationProcessor.Handler.Application
{
    public class UnSuccessfulApplicationHandler : ApplicationHandler
    {
        public override string HandleRequest(IApplication application)
        {
            if (application.DegreeGrade == DegreeGradeEnum.third)
            {
                return GetHTMLTemplates.GetUnSuccessfulApplicationTemplate(application);
            }

            return base.HandleRequest(application);
        }
    }
}
