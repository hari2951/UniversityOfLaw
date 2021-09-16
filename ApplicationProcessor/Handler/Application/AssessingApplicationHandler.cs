using Ulaw.ApplicationProcessor.Entity.Application;
using Ulaw.ApplicationProcessor.Helper;

namespace Ulaw.ApplicationProcessor.Handler.Application
{
    public class AssessingApplicationHandler : ApplicationHandler
    {
        public override string HandleRequest(IApplication application)
            => GetHTMLTemplates.GetAssessingfulApplicationTemplate(application);
    }
}
