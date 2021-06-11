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
        public ActionResult Index(string name, int universityId)
        {
            if (name.Equals("Sheffield"))
                return RedirectToAction("CoursesSheffield", new { universityId = universityId });
            else if (name.Equals("Sheffield Hallam"))
                return RedirectToAction("CoursesSheffieldHallam", new { universityId = universityId });
            return RedirectToAction("Index", "University");
        }
        public ActionResult CoursesSheffieldHallam(int universityId)
        {
            Session["universityId"] = universityId;
            return View(service.getSheffieldHallamCourses());
        }

        public ActionResult CoursesSheffield(int universityId)
        {
            Session["universityId"] = universityId;
            return View(service.GetSheffieldCourses());
        }
    }
}