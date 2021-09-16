using System.Text;
using Ulaw.ApplicationProcessor.Entity.Application;
using Ulaw.ApplicationProcessor.Enums;

namespace Ulaw.ApplicationProcessor.Handler.Application
{
    public class UnSuccessfulApplicationHandler : ApplicationHandler
    {
        //private readonly IApplication application;

        //public UnSuccessfulApplicationHandler(IApplication application)
        //{
        //    this.application = application;
        //}
        public override string HandleRequest(IApplication application)
        {
            if (application.DegreeGrade == DegreeGradeEnum.third)
            {
                var result = new StringBuilder("<html><body><h1>Your Recent Application from the University of Law</h1>");
                result.Append(string.Format("<p> Dear {0}, </p>", application.FirstName));
                result.Append("<p/> Further to your recent application, we are sorry to inform you that you have not been successful on this occasion.");
                result.Append("<br/> If you wish to discuss the decision further, or discuss the possibility of applying for an alternative course with us, please contact us at AdmissionsTeam@Ulaw.co.uk.");
                result.Append("<br> Yours sincerely,");
                result.Append("<p/> The Admissions Team,");
                result.Append(string.Format("</body></html>"));

                return result.ToString();
            }
            return base.HandleRequest(application);
        }
    }
}
