using System.Text;
using Ulaw.ApplicationProcessor.Entity.Application;
using Ulaw.ApplicationProcessor.Enums;
using ULaw.ApplicationProcessor;

namespace Ulaw.ApplicationProcessor.Handler.Application
{
    public class SuccessfulApplicationHandler : ApplicationHandler
    {
        public override string HandleRequest(IApplication application)
        {
            if (application.DegreeGrade != DegreeGradeEnum.twoTwo && (application.DegreeSubject == DegreeSubjectEnum.law || application.DegreeSubject == DegreeSubjectEnum.lawAndBusiness))
            {
                decimal depositAmount = 350.00M;

                var result = new StringBuilder("<html><body><h1>Your Recent Application from the University of Law</h1>");
                result.Append(string.Format("<p> Dear {0}, </p>", application.FirstName));
                result.Append(string.Format("<p/> Further to your recent application, we are delighted to offer you a place on our course reference: {0} starting on {1}.", application.CourseCode, application.StartDate.ToLongDateString()));
                result.Append(string.Format("<br/> This offer will be subject to evidence of your qualifying {0} degree at grade: {1}.", application.DegreeSubject.ToDescription(), application.DegreeGrade.ToDescription()));
                result.Append(string.Format("<br/> Please contact us as soon as possible to confirm your acceptance of your place and arrange payment of the £{0} deposit fee to secure your place.", depositAmount.ToString()));
                result.Append(string.Format("<br/> We look forward to welcoming you to the University,"));
                result.Append(string.Format("<br/> Yours sincerely,"));
                result.Append(string.Format("<p/> The Admissions Team,"));
                result.Append(string.Format("</body></html>"));


                return result.ToString();
            }
            return base.HandleRequest(application);
        }
    }
}
