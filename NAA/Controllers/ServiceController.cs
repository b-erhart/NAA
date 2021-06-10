using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NAA.InServices.IService;
using NAA.InServices.Service;

namespace NAA.Controllers
{
    public class ServiceController : Controller
    {
        private IInboundService service;
        public ServiceController()
        {
            service = new InboundService();
        }
        // GET: Service
        public ActionResult Index(string name)
        {
            if (name.Equals("Sheffield"))
                RedirectToAction("CoursesSheffieldHallam");
            else if (name.Equals("Sheffield Hallam"))
                RedirectToAction("CoursesSheffield");
            return RedirectToAction("Index", "University");
        }
        public ActionResult CoursesSheffieldHallam()
        {
            return View(service.getSheffieldHallamCourses());
        }

        public ActionResult CoursesSheffield()
        {
            return View(service.GetSheffieldCourses());
        }
    }
}