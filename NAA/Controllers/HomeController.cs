using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NAA.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (!string.IsNullOrEmpty((string)Session["UserId"]))
            {
                return RedirectToAction("Details", "Profile");
            }
            return View();
        }
    }
}