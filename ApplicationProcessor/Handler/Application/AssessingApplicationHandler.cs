using Ulaw.ApplicationProcessor.Entity.Application;
using Ulaw.ApplicationProcessor.Templates;

namespace Ulaw.ApplicationProcessor.Handler.Application
{
    public class AssessingApplicationHandler : ApplicationHandler
    {
        public override string HandleRequest(IApplication application)
            => GetHTMLTemplates.GetAssessingfulApplicationTemplate(application);
    }
}
