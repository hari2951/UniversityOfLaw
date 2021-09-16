using System.Text;
using Ulaw.ApplicationProcessor.Entity.Application;
using Ulaw.ApplicationProcessor.Enums;

namespace Ulaw.ApplicationProcessor.Handler.Application
{
    public class AssessingApplicationHandler : ApplicationHandler
    {
        public override string HandleRequest(IApplication application)
        {
            var result = new StringBuilder("<html><body><h1>Your Recent Application from the University of Law</h1>");
            result.Append(string.Format("<p> Dear {0}, </p>", application.FirstName));
            result.Append(string.Format("<p/> Further to your recent application for our course reference: {0} starting on {1}, we are writing to inform you that we are currently assessing your information and will be in touch shortly.", application.CourseCode, application.StartDate.ToLongDateString()));
            result.Append("<br/> If you wish to discuss any aspect of your application, please contact us at AdmissionsTeam@Ulaw.co.uk.");
            result.Append("<br/> Yours sincerely,");
            result.Append("<p/> The Admissions Team,");
            result.Append(string.Format("</body></html>"));

            return result.ToString();

        }
    }
}
