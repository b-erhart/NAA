using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NAA.Services.IService;
using NAA.Services.Service;
using NAA.Data.Models.Domain;

namespace NAA.Controllers
{
    public class ApplicationController : Controller
    {
        private IUserService userService;
        private IUniversityService universityService;
        private IApplicationService applicationService;

        public ApplicationController()
        {
            userService = new UserService();
            universityService = new UniversityService();
            applicationService = new ApplicationService();
        }
        
        public ActionResult Index(string errorMessage)
        {
            string userId = (string)Session["UserId"];
            User user = userService.GetUser(userId);
            userService.GetApplications(user);

            if (!string.IsNullOrEmpty(errorMessage))
                ViewBag.ErrorMessage = errorMessage;

            return View(userService.GetApplications(user));
        }

        public ActionResult CreateApplication(string course)
        {
            ViewBag.Course = course;
            string userId = (string)Session["UserId"];
            User user = userService.GetUser(userId);
            IList<Application> applications = userService.GetApplications(user);
            if (applications.Count < 5)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", new { errorMessage = "Only 5 Applications allowed" });
            }
        }

        [HttpPost]
        public ActionResult CreateApplication(Application application)
        {
            try
            {
                string userId = (string)Session["UserId"];
                int universityId = (int)Session["universityId"];
                applicationService.AddApplication(application,userId,universityId);

                return RedirectToAction("Index", "University");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult DeleteApplication(int applicationId)
        {
            Application application = applicationService.GetApplication(applicationId);
            if (application.Offer.Equals(""))
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", new { errorMessage = "Application has already an Offer" });
            }
        }

        [HttpPost]
        public ActionResult DeleteApplication(Application application)
        {
            try
            {
                string userId = (string)Session["UserId"];
                applicationService.DeleteApplication(application, userId);

                return RedirectToAction("Index", "University");
            }
            catch
            {
                return View();
            }
        }
    }
}