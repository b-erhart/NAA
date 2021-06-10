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

        public ApplicationController()
        {
            userService = new UserService();
            universityService = new UniversityService();
        }
        
        public ActionResult Index()
        {
            return View(userService.GetApplications());
        }

        public ActionResult CreateApplication(string course)
        {
            ViewBag.Course = course;
            return View();
        }

        [HttpPost]
        public ActionResult CreateApplication(Application application)
        {
            try
            {
                userService.AddApplicationToCollection(application);
                universityService.AddApplicationToCollection(application);

                return RedirectToAction("Index", "University");
            }
            catch
            {
                return View();
            }
        }
    }
}