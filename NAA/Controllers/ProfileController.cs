using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NAA.Data.Models.Domain;
using NAA.Services.IService;
using NAA.Services.Service;

namespace NAA.Controllers
{
    public class ProfileController : Controller
    {
        private IUserService userService;

        public ProfileController()
        {
            userService = new UserService();
        }

        // GET: Profile
        public ActionResult Index()
        {
            return View();
        }

        // GET: Profile/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Profile/Create
        public ActionResult Create()
        {
            User user = userService.GetUser((string)Session["UserId"]);
            return View(user);
        }

        // POST: Profile/Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            try
            {
                User dbUser = userService.GetUser((string)Session["UserId"]);

                if (string.IsNullOrEmpty(user.Address) || string.IsNullOrEmpty(user.Phone))
                {
                    Session["ErrorMessage"] = "Address and Phone are mandatory fields.";
                    return RedirectToAction("Create");
                }

                dbUser.Address = user.Address;
                dbUser.Phone = user.Phone;

                userService.UpdateUser(user);

                return RedirectToAction("Index", "University");
            }
            catch
            {
                return View();
            }
        }

        // GET: Profile/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Profile/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Profile/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Profile/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
