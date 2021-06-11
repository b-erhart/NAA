using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAA.OutServices.IService;
using NAA.Data.Models.Domain;
using NAA.Data.Models.Repository;
using NAA.Data.IDAO;
using NAA.Data.DAO;
using NAA.OutServices.Models;

namespace NAA.OutServices.Service
{
    public class ApplicationService : IApplicationService
    {
        private IUniversityDAO universityDAO;
        private IUserDAO userDAO;
        public ApplicationService()
        {
            universityDAO = new UniversityDAO();
            userDAO = new UserDAO();
        }
        public UniversityApplication[] GetApplications(string universityName)
        {
            using (var context = new NAAContext())
            {
                IList<Application> applications = universityDAO.GetApplications(context, universityName);
                UniversityApplication[] universityApplications = new UniversityApplication[applications.Count];

                for (int i = 0; i < universityApplications.Length; i++)
                {
                    Application application = applications[i];
                    IList<User> users = userDAO.GetUsers(context);
                    User applicationUser = null;

                    foreach (var user in users)
                    {
                        IList<Application> userApplications = user.Applications.ToList();
                        foreach (var userApplication in userApplications)
                        {
                            if (userApplication.ApplicationId == application.ApplicationId)
                            {
                                applicationUser = user;
                                break;
                            }
                        }
                        if (applicationUser != null)
                        {
                            break;
                        }
                    }

                    UniversityApplication universityApplication = new UniversityApplication()
                    {
                        ApplicationId = application.ApplicationId,
                        StudentName = applicationUser.Name,
                        StudentAddress = applicationUser.Address,
                        StudentPhone = applicationUser.Phone,
                        StudentEmail = applicationUser.Email,
                        Course = application.Course,
                        Statement = application.Statement,
                        TeacherContact = application.TeacherContact,
                        Offer = application.Offer,
                        Firm = application.Firm
                    };

                    universityApplications[i] = universityApplication;
                }

                return universityApplications;
            }
        }

        public string MakeOffer(string universityName, int applicationId, string offer, string statement, string teacherContact, string teacherReference)
        {
            using (var context = new NAAContext())
            {
                IList<Application> applications = universityDAO.GetApplications(context, universityName);
                Application applicationToMakeOffer = null;

                foreach (var application in applications)
                {
                    if (application.ApplicationId == applicationId)
                    {
                        applicationToMakeOffer = application;
                        break;
                    }
                }

                if (applicationToMakeOffer == null)
                {
                    return "There is no application with id \"" + applicationId + "\" for " + universityName + ".";
                }

                if (string.IsNullOrEmpty(offer))
                {
                    return "Offer cannot be empty.";
                }

                switch (offer)
                {
                    case "R":
                        if (applicationToMakeOffer.Offer == "C" || applicationToMakeOffer.Offer == "U")
                        {
                            return "Offer already has state \"" + applicationToMakeOffer.Offer + "\" and can therefore not be rejected.";
                        }
                        applicationToMakeOffer.Offer = "R";
                        break;
                    case "P":
                        if (applicationToMakeOffer.Offer == "C" || applicationToMakeOffer.Offer == "U" || applicationToMakeOffer.Offer == "R")
                        {
                            return "Offer already has state \"" + applicationToMakeOffer.Offer + "\" and can therefore not be set to pending.";
                        }
                        applicationToMakeOffer.Offer = "P";
                        break;
                    case "C":
                        if (applicationToMakeOffer.Offer == "U")
                        {
                            return "Offer already has state \"" + applicationToMakeOffer.Offer + "\" and can therefore not be set to conditional.";
                        }
                        applicationToMakeOffer.Offer = "C";
                        break;
                    case "U":
                        applicationToMakeOffer.Offer = "U";
                        break;
                    default:
                        return "\"" + offer + "\" is not a valid value for offer. Only R (reject), P (pending), C (conditional) and U (unconditional) are allowed.";
                }

                applicationToMakeOffer.Statement = statement;
                applicationToMakeOffer.TeacherContact = teacherContact;
                applicationToMakeOffer.TeacherReference = teacherReference;

                return "Offer sent successfully.";
            }
        }
    }
}
