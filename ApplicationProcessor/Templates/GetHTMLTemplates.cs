using System.Text;
using Ulaw.ApplicationProcessor.Entity.Application;
using ULaw.ApplicationProcessor.Enums;

namespace Ulaw.ApplicationProcessor.Templates
{
    public static class GetHTMLTemplates
    {
        public static string GetSuccessfulApplicationTemplate(IApplication application)
        {
            var res = new StringBuilder();
            res.Append($"{GetHeader(application.FirstName)}");
            res.Append($"{GetSuccessApplicationBody(application)}");
            res.Append($"{GetFooter()}");

            return res.ToString();
        }

        public static string GetUnSuccessfulApplicationTemplate(IApplication application)
        {
            var res = new StringBuilder();
            res.Append($"{GetHeader(application.FirstName)}");
            res.Append($"{GetUnSuccessApplicationBody()}");
            res.Append($"{GetFooter()}");

            return res.ToString();
        }

        public static string GetAssessingfulApplicationTemplate(IApplication application)
        {
            var res = new StringBuilder();
            res.Append($"{GetHeader(application.FirstName)}");
            res.Append($"{GetAssessingApplicationBody(application)}");
            res.Append($"{GetFooter()}");

            return res.ToString();
        }

        private static string GetHeader(string firstName)
        {
            var result = new StringBuilder("<html><body><h1>Your Recent Application from the University of Law</h1>");
            result.Append(string.Format($"<p> Dear {firstName}, </p>"));

            return result.ToString();
        }

        private static string GetFooter()
        {
            var result = new StringBuilder("<br/> Yours sincerely,");
            result.Append("<p/> The Admissions Team,");
            result.Append(string.Format("</body></html>"));

            return result.ToString();
        }
        private static string GetSuccessApplicationBody(IApplication application)
        {
            var depositAmount = 350.00M;
            var result = new StringBuilder($"<p/> Further to your recent application, we are delighted to offer you a place on our course reference: {application.CourseCode} starting on {application.StartDate.ToLongDateString()}.");
            result.Append(string.Format($"<br/> This offer will be subject to evidence of your qualifying {application.DegreeSubject.ToDescription()} degree at grade: {application.DegreeGrade.ToDescription()}."));
            result.Append(string.Format($"<br/> Please contact us as soon as possible to confirm your acceptance of your place and arrange payment of the £{depositAmount} deposit fee to secure your place."));
            result.Append(string.Format("<br/> We look forward to welcoming you to the University,"));

            return result.ToString();
        }

        private static string GetUnSuccessApplicationBody()
        {
            var result = new StringBuilder("<p/> Further to your recent application, we are sorry to inform you that you have not been successful on this occasion.");
            result.Append("<br/> If you wish to discuss the decision further, or discuss the possibility of applying for an alternative course with us, please contact us at AdmissionsTeam@Ulaw.co.uk.");


            return result.ToString();
        }

        private static string GetAssessingApplicationBody(IApplication application)
        {
            var result = new StringBuilder($"<p/> Further to your recent application for our course reference: {application.CourseCode} starting on {application.StartDate.ToLongDateString()}, we are writing to inform you that we are currently assessing your information and will be in touch shortly.");
            result.Append("<br/> If you wish to discuss any aspect of your application, please contact us at AdmissionsTeam@Ulaw.co.uk.");

            return result.ToString();
        }
    }
}
