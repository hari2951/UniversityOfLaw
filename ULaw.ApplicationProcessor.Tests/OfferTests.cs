using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ulaw.ApplicationProcessor.Entities.Application;
using Ulaw.ApplicationProcessor.Entities.Candidates;
using Ulaw.ApplicationProcessor.Entities.Courses;
using Ulaw.ApplicationProcessor.Enums;

namespace ULaw.ApplicationProcessor.Tests
{

    [TestClass]
    public class ApplicationSubmissionTests
    {
        private const string OfferEmailForFirstLawDegreeResult = @"<html><body><h1>Your Recent Application from the University of Law</h1><p> Dear Test, </p><p/> Further to your recent application, we are delighted to offer you a place on our course reference: ABC123 starting on 22 September 2019.<br/> This offer will be subject to evidence of your qualifying Law degree at grade: 1st.<br/> Please contact us as soon as possible to confirm your acceptance of your place and arrange payment of the £350.00 deposit fee to secure your place.<br/> We look forward to welcoming you to the University,<br/> Yours sincerely,<p/> The Admissions Team,</body></html>";
        private const string OfferEmailForTwoOneLawDegreeResult = @"<html><body><h1>Your Recent Application from the University of Law</h1><p> Dear Test, </p><p/> Further to your recent application, we are delighted to offer you a place on our course reference: ABC123 starting on 22 September 2019.<br/> This offer will be subject to evidence of your qualifying Law degree at grade: 2:1.<br/> Please contact us as soon as possible to confirm your acceptance of your place and arrange payment of the £350.00 deposit fee to secure your place.<br/> We look forward to welcoming you to the University,<br/> Yours sincerely,<p/> The Admissions Team,</body></html>";
        private const string OfferEmailForFirstLawAndBusinessDegreeResult = @"<html><body><h1>Your Recent Application from the University of Law</h1><p> Dear Test, </p><p/> Further to your recent application, we are delighted to offer you a place on our course reference: ABC123 starting on 22 September 2019.<br/> This offer will be subject to evidence of your qualifying Law and Business degree at grade: 1st.<br/> Please contact us as soon as possible to confirm your acceptance of your place and arrange payment of the £350.00 deposit fee to secure your place.<br/> We look forward to welcoming you to the University,<br/> Yours sincerely,<p/> The Admissions Team,</body></html>";
        private const string OfferEmailForTwoOneLawAndBusinessDegreeResult = @"<html><body><h1>Your Recent Application from the University of Law</h1><p> Dear Test, </p><p/> Further to your recent application, we are delighted to offer you a place on our course reference: ABC123 starting on 22 September 2019.<br/> This offer will be subject to evidence of your qualifying Law and Business degree at grade: 2:1.<br/> Please contact us as soon as possible to confirm your acceptance of your place and arrange payment of the £350.00 deposit fee to secure your place.<br/> We look forward to welcoming you to the University,<br/> Yours sincerely,<p/> The Admissions Team,</body></html>";

        private const string FurtherInfoEmailResult = @"<html><body><h1>Your Recent Application from the University of Law</h1><p> Dear Test, </p><p/> Further to your recent application for our course reference: ABC123 starting on 22 September 2019, we are writing to inform you that we are currently assessing your information and will be in touch shortly.<br/> If you wish to discuss any aspect of your application, please contact us at AdmissionsTeam@Ulaw.co.uk.<br/> Yours sincerely,<p/> The Admissions Team,</body></html>";
        private const string RejectionEmailForAnyThirdDegreeResult = @"<html><body><h1>Your Recent Application from the University of Law</h1><p> Dear Test, </p><p/> Further to your recent application, we are sorry to inform you that you have not been successful on this occasion.<br/> If you wish to discuss the decision further, or discuss the possibility of applying for an alternative course with us, please contact us at AdmissionsTeam@Ulaw.co.uk.<br/> Yours sincerely,<p/> The Admissions Team,</body></html>";

        private ICandidate _candidate;
        private ICourse _course;

        [TestInitialize]
        public void Setup()
        {
            _candidate = new Candidate
            {
                Title = "Mr",
                FirstName = "Test",
                LastName  = "Tester",
                DateOfBirth = new DateTime(1991, 08, 14),
                RequiresVisa = false
            };

            _course = new Course { 
                Faculty = "Law",
                CourseCode = "ABC123",
                StartDate = new DateTime(2019, 9, 22) };
        }


        [TestMethod]
        public void ApplicationSubmissionWithFirstLawDegree()
        {
            _candidate.DegreeGrade = DegreeGradeEnum.First;
            _candidate.DegreeSubject = DegreeSubjectEnum.Law;
            Application thisSubmission = new Application(_candidate, _course);

            string emailHtml = thisSubmission.Process();
            Assert.AreEqual(emailHtml, OfferEmailForFirstLawDegreeResult);
        }

        [TestMethod]
        public void ApplicationSubmissionWithFirstLawAndBusinessDegree()
        {
            _candidate.DegreeGrade = DegreeGradeEnum.First;
            _candidate.DegreeSubject = DegreeSubjectEnum.LawAndBusiness;
            Application thisSubmission = new Application(_candidate, _course);

            string emailHtml = thisSubmission.Process();
            Assert.AreEqual(emailHtml, OfferEmailForFirstLawAndBusinessDegreeResult);
        }

        [TestMethod]
        public void ApplicationSubmissionWithFirstEnglishDegree()
        {
            _candidate.DegreeGrade = DegreeGradeEnum.First;
            _candidate.DegreeSubject = DegreeSubjectEnum.English;
            Application thisSubmission = new Application(_candidate, _course);

            string emailHtml = thisSubmission.Process();
            Assert.AreEqual(emailHtml, FurtherInfoEmailResult);
        }

        [TestMethod]
        public void ApplicationSubmissionWithTwoOneLawDegree()
        {
            _candidate.DegreeGrade = DegreeGradeEnum.TwoOne;
            _candidate.DegreeSubject = DegreeSubjectEnum.Law;
            Application thisSubmission = new Application(_candidate, _course);

            string emailHtml = thisSubmission.Process();
            Assert.AreEqual(emailHtml, OfferEmailForTwoOneLawDegreeResult);
        }

        [TestMethod]
        public void ApplicationSubmissionWithTwoOneMathsDegree()
        {
            _candidate.DegreeGrade = DegreeGradeEnum.TwoOne;
            _candidate.DegreeSubject = DegreeSubjectEnum.Maths;
            Application thisSubmission = new Application(_candidate, _course);

            string emailHtml = thisSubmission.Process();
            Assert.AreEqual(emailHtml, FurtherInfoEmailResult);
        }

        [TestMethod]
        public void ApplicationSubmissionWithTwoOneLawAndBusinessDegree()
        {
            _candidate.DegreeGrade = DegreeGradeEnum.TwoOne;
            _candidate.DegreeSubject = DegreeSubjectEnum.LawAndBusiness;
            Application thisSubmission = new Application(_candidate, _course);

            string emailHtml = thisSubmission.Process();
            Assert.AreEqual(emailHtml, OfferEmailForTwoOneLawAndBusinessDegreeResult);
        }

        [TestMethod]
        public void ApplicationSubmissionWithTwoTwoEnglishDegree()
        {
            _candidate.DegreeGrade = DegreeGradeEnum.TwoTwo;
            _candidate.DegreeSubject = DegreeSubjectEnum.English;
            Application thisSubmission = new Application(_candidate, _course);

            string emailHtml = thisSubmission.Process();
            Assert.AreEqual(emailHtml, FurtherInfoEmailResult);
        }

        [TestMethod]
        public void ApplicationSubmissionWithTwoTwoLawDegree()
        {
            _candidate.DegreeGrade = DegreeGradeEnum.TwoTwo;
            _candidate.DegreeSubject = DegreeSubjectEnum.Law;
            Application thisSubmission = new Application(_candidate, _course);

            string emailHtml = thisSubmission.Process();
            Assert.AreEqual(emailHtml, FurtherInfoEmailResult);
        }

        [TestMethod]
        public void ApplicationSubmissionWithThirdDegree()
        {
            _candidate.DegreeGrade = DegreeGradeEnum.Third;
            _candidate.DegreeSubject = DegreeSubjectEnum.Maths;
            Application thisSubmission = new Application(_candidate, _course);

            string emailHtml = thisSubmission.Process();
            Assert.AreEqual(emailHtml, RejectionEmailForAnyThirdDegreeResult);
        }
    }
}
